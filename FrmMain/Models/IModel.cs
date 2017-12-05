using System;
using System.Collections.Generic;
using System.IO;
using DeXrm.Win.Datos;
using DeXrm.Win.Object;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Tooling.Connector;

namespace DeXrm.Win.Tools.Models
{
    //using Microsoft.Crm.Sdk.Helper;
    public interface IModelFrmMain : ISuperBase
    {
        CrmServiceClient ServerConnection { get; set; }
        SolutionData Solution { get; set; }
        string PathPackage { get; set; }
        string UpdateXmlResource { get; set; }
        FileStream FileStream { get; set; }
        Guid GuiViewIdGuid { get; set; }
        string FetchXmlImport { get; set; }

        string EntityCollection { get; set; }

        //ServerConnection.Configuration ImportConfiguration { get; set; }
        string NewEntityCollectionToImport { get; set; }

        string EntityName { get; set; }
        EntityMetadata EntityMetadata { get; set; }
        string TotalScriptPreview { get; set; }
        List<PluginObject> Plugins { get; set; }
        List<Dx_Attribute> Attribute { get; set; }
        Guid SystemUserConnectedGuid { get; set; }
        void GetSolutions();
        void GetWebResources();
        void SavePackages();
        void OpenPackage();
        void Publish();
        void UpdateResource();
        void PublishSelected();
        void ConvertFile();
        void GetView();
        void GetViewById();
        void ExecuteFetchImport();
        void ImportDataView();
        void GetFristOfThem();
        void GetEntities();
        void GetEntity();
        void GetAllPlugin();
        void SavePlugin();
        void Dispose();
        void ImportExcel();
        void GetAttributes();
        void GetSolutions(CrmServiceClient pServiceClient);
        string GetConnectionName();
    }
}