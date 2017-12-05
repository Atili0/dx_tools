using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;
using DeXrm.Win.Datos;
using DeXrm.Win.Datos.Export;
using DeXrm.Win.Datos.Import;
using DeXrm.Win.Object;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Tooling.Connector;

namespace DeXrm.Win.Tools.Models
{
    public class ModelFrmMain : SuperBase, IModelFrmMain, IDisposable
    {
        private bool disposed;
        public XElement XmlPackageData;
        public EntityCollection Collection { get; set; }

        public string GetConnectionName()
        {
            return OrganizationData.GetConnectionName(ServerConnection, SystemUserConnectedGuid);
        }

        public void GetEntity()
        {
            //this.EntityMetadata = new IntellisenseData().GetEntity(this.ServerConfiguration, this.EntityName);
        }

        public void GetEntities()
        {
            Entities = new IntellisenseData().GetEntities(ServerConnection);
        }

        public void Publish()
        {
            new SolutionData().PublishAll(ServerConnection);
        }

        public void PublishSelected()
        {
            new SolutionData().PublishSelected(ServerConnection, UpdateXmlResource);
        }

        public void UpdateResource()
        {
            new WebResourceData().UpdateResource(ServerConnection, WebResourceObject);
        }

        public void GetSolutions()
        {
            SolutionObjects = new SolutionData().GetAllSolution(ServerConnection);
        }

        public void GetSolutions(CrmServiceClient pServiceClient)
        {
            SolutionObjects = new SolutionData().GetAllSolution(pServiceClient);
        }

        public void GetWebResources()
        {
            WebResourcesObjects = new WebResourceData().GetWebResources(ServerConnection,
                Solution);
        }

        public void SavePackages()
        {
            var directoryPath = string.Format("{0}\\{1}\\{2}",
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                rsTool.OrganizationData_GetAllOrganization_config,
                rsTool.OrganizationData_GetAllOrganization_package);

            Datos.Configuration.CreateForder(directoryPath);

            var filePath = string.Format(rsTool.PackagesFilename,
                QuickPublish.SolutionName,
                QuickPublish.SolutionGuid);

            var CompletePath = string.Format("{0}\\{1}", directoryPath, filePath);

            var serializer = new XmlSerializer(QuickPublish.GetType());

            using (var writer = new FileStream(CompletePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.Serialize(writer, QuickPublish);
                writer.Flush();
            }
        }

        public void OpenPackage()
        {
            var deSerializer = new XmlSerializer(new QuickPublish().GetType());
            using (var reader = new StreamReader(PathPackage))
            {
                var quickPublish = (QuickPublish) deSerializer.Deserialize(reader);
                Solution = new SolutionData
                {
                    SolutionId = quickPublish.SolutionGuid
                };
                WebResourcesObjects = quickPublish.WebResourceObjects;
            }
        }

        #region Import Excel

        public void ImportExcel()
        {
        }

        #endregion

        #region Get Attributes

        public void GetAttributes()
        {
            Attribute = new ImportEntity().GetAttributesByEntityId(EntityName, ServerConnection);
        }

        #endregion


        public CrmServiceClient ServerConnection { get; set; }
        public SolutionData Solution { get; set; }
        public string PathPackage { get; set; }
        public string UpdateXmlResource { get; set; }
        public Guid GuiViewIdGuid { get; set; }
        public string FetchXmlImport { get; set; }
        public string EntityCollection { get; set; }
        public string NewEntityCollectionToImport { get; set; }
        public string EntityName { get; set; }
        public EntityMetadata EntityMetadata { get; set; }
        public string TotalScriptPreview { get; set; }
        public List<PluginObject> Plugins { get; set; }
        public List<Dx_Attribute> Attribute { get; set; }
        public Guid SystemUserConnectedGuid { get; set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void UpdateAndPublishResource()
        {
            foreach (var resourceObject in QuickPublish.WebResourceObjects)
            {
                //new WebResourceData().UpdateResource(this.ServerConfiguration, resourceObject);
            }
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }

        #region Import

        public void GetFristOfThem()
        {
            NewEntityCollectionToImport = new ViewData().GetFirstOfThem(Collection);
        }

        public void ImportDataView()
        {
            //this.Collection = new ViewData().GetAllCollection(this.ServerConfiguration, this.FetchXmlImport);
            //new ViewData().ImportaData(this.ImportConfiguration, this.Collection, this.EntityName);
        }

        public void ExecuteFetchImport()
        {
            EntityCollection collectionEntities;
            //this.EntityCollection = new ViewData().ExecuteFetchImport(this.ServerConfiguration, this.FetchXmlImport, out collectionEntities);
            //this.Collection = collectionEntities;
            //this.EntityName = collectionEntities.EntityName;
        }

        public void GetView()
        {
            //this.ViewsList = new ViewData().GetView(this.ServerConfiguration);
        }

        public void GetViewById()
        {
            //this.ViewObject = new ViewData().GetViewById(this.ServerConfiguration, this.GuiViewIdGuid);
        }

        #endregion

        #region Trace

        public void ConvertFile()
        {
            LogObjects = new Util().ConvertFile(FileStream);
        }

        public FileStream FileStream { get; set; }

        #endregion

        #region Export Plugin

        public void GetAllPlugin()
        {
            Plugins = new PluginData().GetAllPluginsList(ServerConnection);
        }

        public void SavePlugin()
        {
            var path = PluginData.SafeCreateDirectory();
            foreach (var pluginObject in Plugins)
                PluginData.CreateAssembly(pluginObject, path);
        }

        #endregion
    }
}