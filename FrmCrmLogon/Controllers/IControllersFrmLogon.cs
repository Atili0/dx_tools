namespace DeXrm.Win.Tools.Controllers
{
    using System;

    public interface IControllersFrmLogon
    {
        void DisableField();
        void EnableField();
        void GenerateConfig();
        void GetUrlServer();
        void RetrieveOrganization();
        void GetConfigSaved();
        void SetConfiguration();
    }
}