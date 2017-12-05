using System;
using DeXrm.Win.Tools.Controllers;
using DeXrm.Win.Tools.Models;

namespace DeXrm.Win.Tools.Views
{
    public interface IViewFrmLogon
    {
        void setController(IControllersFrmLogon cont);
        void DisableField();
        void EnableField();
        String UrlServer { get; set; }
        String User { get; set; }
        String Domain { get; set; }
        String Password { get; set; }
        String TypeUrl { get; set; }
        String TypeConnection { get; set; }
        Boolean InternalUser { get; set; }
        String SavedConfig { get; set; }
        Boolean IsTemplate { get; set; }
        Boolean IsOnline { get; set; }
        String Organization { get; set; }
        void DisableServerField();
        void EnableServerField();
        void SetConfigSaved(IModelsFrmLogon modelsFrmLogon);
        void SetOrganization(IModelsFrmLogon modelsFrmLogon);
        void SetConfiguration(IModelsFrmLogon modelsFrmLogon);
    }
}