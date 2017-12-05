using System.Collections.Generic;
using DeXrm.Win.Object;
using Microsoft.Xrm.Tooling.Connector;

namespace DeXrm.Win.Tools.Controllers
{
    public interface IControllerFrmMain
    {
        QuickPublish QuickPublish { get; set; }
        string PathPackage { get; set; }
        List<WebResourceObject> WebResourceObjects { get; set; }
        List<PluginObject> PluginObjects { get; set; }
        void ChangeTheme();
        void GetFormConfigurationConnection();
        void GetSolutions();
        void GetWebResource();
        void SavePackages();
        void SetConnectionName();
        void OpenPackage();
        void Publish();
        void UpdateResource();
        void GetValueString(string optionName, string regKeyPath);
        void GetView();
        void GetViewById();
        void ExecuteFetchImport();
        void ImportDataView();
        void GetEntities();
        void GetPreviewScript();
        void SaveScript();
        void GetAllPlugin();
        void SavePlugin();
        void ImportEntity();
        void GetAttributesByEntity();
        void GetSolutions(CrmServiceClient pServiceClient, bool isPro);
    }
}