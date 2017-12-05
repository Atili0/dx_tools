using System;
using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Models;
using Microsoft.Xrm.Tooling.Connector;

namespace DeXrm.Win.Tools.Views
{
    public interface IView
    {
        string PathExcel { get; set; }
        CrmServiceClient ServerConnection { get; set; }
        string SolutionId { get; }
        string InitialDirectory { get; set; }
        string FilePath { get; set; }
        Guid GuidViewGuid { get; set; }
        string EntityId { get; set; }
        CrmServiceClient ServerDeployConnection { get; set; }
        Guid SystemUserConnectedGuid { get; set; }
        void setController(IControllerFrmMain cont);
        void LoadEventArgs();
        void GetFormConfigurationConnection();

        void SetSolution(IModelFrmMain modelFrmMain);
        void SetWebResource(IModelFrmMain modelFrmMain);
        void SetSolutionForId(IModelFrmMain modelFrmMain);
        void FillGridViewTrace(IModelFrmMain modelFrmMain);
        void Message();
        void SetView(IModelFrmMain model);
        void SetFieldForView(IModelFrmMain model);
        void SetGridResultFetch(IModelFrmMain model);
        void SetImportGrid(IModelFrmMain modelFrmMain);
        void SetListPlugin(IModelFrmMain modelFrmMain);
        void SetEntity(IModelFrmMain modelFrmMain);
        void SetAttribute(IModelFrmMain modelFrmMain);
        void ShowSolution(IModelFrmMain modelFrmMain);
        void ShowSolutionPro(IModelFrmMain modelFrmMain);
        void SetConnectionName(IModelFrmMain modelFrmMain);
    }
}