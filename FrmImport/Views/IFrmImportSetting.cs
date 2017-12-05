using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Models;

namespace DeXrm.Win.Tools.FrmImport.Views
{
    public interface IFrmImportSetting
    {
        string UrlServer { get; set; }
        string User { get; set; }
        string Domain { get; set; }
        string Password { get; set; }
        string TypeUrl { get; set; }
        string TypeConnection { get; set; }
        bool InternalUser { get; set; }
        string SavedConfig { get; set; }
        bool IsTemplate { get; set; }
        bool IsOnline { get; set; }
        string Organization { get; set; }
        void SetController(IControllersFrmImport cont);
        void DisableField();
        void EnableField();
        void DisableServerField();
        void EnableServerField();
        void SetOrganization(IModelsFrmImport modelsFrmLogon);
        void SetConfigSaved(IModelsFrmImport modelsFrmLogon);
        void SetConfiguration(IModelsFrmImport modelsFrmLogon);
    }
}