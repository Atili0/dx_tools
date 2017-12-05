using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using C1.C1Excel;
using DeXrm.Win.Datos;
using DeXrm.Win.Object;
using DeXrm.Win.Tools.Models;
using DeXrm.Win.Tools.Views;
using Microsoft.Win32;
using Microsoft.Xrm.Tooling.Connector;
using NLog;

namespace DeXrm.Win.Tools.Controllers
{
    public class ControllerFrmMain : IControllerFrmMain
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Conexion _conexion;
        private readonly IModelFrmMain _model;
        private readonly IView _view;


        public ControllerFrmMain(IView view, IModelFrmMain model)
        {
            _view = view;
            _model = model;
            _view.setController(this);
        }

        public List<Guid> GuidsWebResources { get; set; }

        public async void Publish()
        {
            var retorno = Task.Run(() => PublicTaskAsyn());
            var x = await retorno;
            if (x)
                _view.Message();
        }

        public async void UpdateResource()
        {
            var retorno = Task.Run(() => PublishSelectedAsyn());
            var x = await retorno;
            if (x)
                _view.Message();
        }

        public void SetConnectionName()
        {
            _model.ServerConnection = _view.ServerDeployConnection;
            _model.SystemUserConnectedGuid = _view.SystemUserConnectedGuid;
            _model.GetConnectionName();
            _view.SetConnectionName(_model);
        }

        public void ChangeTheme()
        {
            _view.LoadEventArgs();
        }

        public void GetFormConfigurationConnection()
        {
            _view.GetFormConfigurationConnection();
        }

        public async void GetSolutions()
        {
            var retorno = Task.Run(() => GetSolutionAsyn());
            if (await retorno)
            {
                _view.SetSolution(_model);
                _view.Message();
            }
        }


        public async void GetSolutions(CrmServiceClient pServiceClient, bool isPro)
        {
            var retorno = Task.Run(() => GetSolutionAsyn(pServiceClient));
            if (await retorno)
            {
                if (isPro) _view.ShowSolutionPro(_model);
                else _view.ShowSolution(_model);
                _view.Message();
            }
        }


        public void SavePackages()
        {
            _model.QuickPublish = QuickPublish;
            _model.SavePackages();
        }

        public void GetWebResource()
        {
            _model.Solution = new SolutionData
            {
                SolutionId = new Guid(_view.SolutionId)
            };
            _model.GetWebResources();
            _view.SetWebResource(_model);
        }

        public void OpenPackage()
        {
            _model.PathPackage = PathPackage;
            _model.OpenPackage();
            _view.SetWebResource(_model);
            _view.SetSolutionForId(_model);
        }


        public QuickPublish QuickPublish { get; set; }
        public string PathPackage { get; set; }
        public List<WebResourceObject> WebResourceObjects { get; set; }
        public List<PluginObject> PluginObjects { get; set; }

        private bool PublicTaskAsyn()
        {
            foreach (var webResourceObject in WebResourceObjects)
            {
                _model.WebResourceObject = webResourceObject;
                _model.UpdateResource();
            }
            _model.Publish();
            return true;
        }

        private bool PublishSelectedAsyn()
        {
            GuidsWebResources = new List<Guid>();
            foreach (var webResourceObject in WebResourceObjects)
            {
                _model.WebResourceObject = webResourceObject;
                _model.UpdateResource();
                GuidsWebResources.Add(webResourceObject.WebResourceId);
            }
            GenerateStringAndPublish();
            return true;
        }

        private void GenerateStringAndPublish()
        {
            var allGuid = new StringBuilder();
            foreach (var guid in GuidsWebResources)
                allGuid.Append(string.Format(rsTool.ParamsResource, guid.ToString()));
            _model.UpdateXmlResource = allGuid.ToString();
            _model.PublishSelected();
        }

        private bool GetSolutionAsyn()
        {
            _model.ServerConnection = _view.ServerConnection;
            _model.GetSolutions();
            return true;
        }

        private bool GetSolutionAsyn(CrmServiceClient pServiceClient)
        {
            _model.ServerConnection = pServiceClient;
            _model.GetSolutions(pServiceClient);
            return true;
        }

        #region Import Entity

        public bool ImportEntityAsyn()
        {
            try
            {
                var xlBook = new C1XLBook();
                xlBook.Load(_view.FilePath);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async void ImportEntity()
        {
            var retorno = Task.Run(() => ImportEntityAsyn());
            var x = await retorno;
            if (x)
                _view.Message();
        }

        public void GetAttributesByEntity()
        {
            _model.EntityName = _view.EntityId;
            _model.GetAttributes();
            _view.SetAttribute(_model);
            //return true;
        }


        //public async void GetAttributesByEntity()
        //{
        //    var retorno = System.Threading.Tasks.Task.Run(() => GetAttributesByEntityAsyn());
        //    var x = await retorno;
        //    if (x)
        //    {
        //        _view.Message();
        //    }
        //}

        #endregion

        #region Intellisense

        public async void GetEntities()
        {
            var retorno = Task.Run(() => GetEntitiesAsyn());
            var x = await retorno;
            if (x)
            {
                _view.SetEntity(_model);
                _view.Message();
            }
        }

        private bool GetEntitiesAsyn()
        {
            _model.ServerConnection = _view.ServerConnection;
            _model.GetEntities();
            return true;
        }

        public async void GetPreviewScript()
        {
            //_model.EntityName = _view.EntityScript;
            //var retorno = System.Threading.Tasks.Task.Run(() => GetPreviewScriptAsyn());
            //var x = await retorno;
            //if (x)
            //{
            //    _view.SetPreview(_model);
            //    _view.Message();
            //}
        }

        //private Boolean GetPreviewScriptAsyn()
        //{
        //    _model.GetEntity();
        //    _model.TotalScriptPreview = ScriptGeneratorData.GenerateJavascript(_model.EntityMetadata);
        //    return true;
        //}

        public void SaveScript()
        {
            //var generalPath = String.Format("{0}\\{1}.{2}", _view.PathScript, _view.EntityScript,"js");
            //var fs = new FileStream(generalPath, FileMode.OpenOrCreate, FileAccess.Write);
            //var writer = new StreamWriter(fs);
            //writer.Write(_view.PreviewScript);
            //writer.Close();
            //_view.Message();
        }

        #endregion

        #region Export Plugin

        public async void GetAllPlugin()
        {
            var retorno = Task.Run(() => GetAllPluginAsyn());
            var x = await retorno;
            if (x)
            {
                _view.SetListPlugin(_model);
                _view.Message();
            }
        }

        public bool GetAllPluginAsyn()
        {
            _model.ServerConnection = _view.ServerConnection;
            _model.GetAllPlugin();
            return true;
        }

        public async void SavePlugin()
        {
            var retorno = Task.Run(() => SavePluginAsyn());
            var x = await retorno;
            if (x)
                _view.Message();
        }


        public bool SavePluginAsyn()
        {
            _model.Plugins = PluginObjects;
            _model.SavePlugin();
            return true;
        }

        #endregion

        #region Import

        public async void ImportDataView()
        {
            //_model.ImportConfiguration = _view.ImportServerConnection.configurations[0];
            _model.GetFristOfThem();
            _view.SetImportGrid(_model);
            var retorno = Task.Run(() => ImportDataViewAsyn());
            if (await retorno)
                _view.Message();
        }

        public bool ImportDataViewAsyn()
        {
            _model.ImportDataView();
            return true;
        }

        public async void GetView()
        {
            var retorno = Task.Run(() => GetViewAsyn());
            if (await retorno)
            {
                _view.SetView(_model);
                _view.Message();
            }
        }

        private bool GetViewAsyn()
        {
            //_model.ServerConfiguration = _view.ServerConnection.configurations[0];
            _model.GetView();
            return true;
        }

        public async void GetViewById()
        {
            var retorno = Task.Run(() => GetViewByIdAsyn());
            if (await retorno)
            {
                _view.SetFieldForView(_model);
                _view.Message();
            }
        }

        public bool GetViewByIdAsyn()
        {
            //_model.ServerConfiguration = _view.ServerConnection.configurations[0];
            _model.GuiViewIdGuid = _view.GuidViewGuid;
            _model.GetViewById();
            return true;
        }

        public async void ExecuteFetchImport()
        {
            var retorno = Task.Run(() => ExecuteFetchImportAsyn());
            if (await retorno)
            {
                _view.SetGridResultFetch(_model);
                _view.Message();
            }
        }

        public bool ExecuteFetchImportAsyn()
        {
            //_model.FetchXmlImport = _view.FetchXmlView;
            //_model.ExecuteFetchImport();
            return true;
        }

        #endregion

        #region Trace

        public void GetValueString(string optionName, string regKeyPath)
        {
            using (var registryKey = OpenSubKey(regKeyPath))
            {
                registryKey.GetValue(optionName, null);
            }
        }

        private static RegistryKey OpenSubKey(string regKeyPath, bool writeable = false)
        {
            return Registry.LocalMachine.OpenSubKey(regKeyPath, writeable);
        }

        public void FillGridView()
        {
            var fileInfo = new FileInfo(_view.FilePath);
            if (!fileInfo.Exists)
                return;

            using (var fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                _model.FileStream = fileStream;
                _model.ConvertFile();
            }
            _view.FillGridViewTrace(_model);
        }

        #endregion
    }
}