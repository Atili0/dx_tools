namespace DeXrm.Win.Tools.Models
{
    using System;
    using DeXrm.Win.Object;
    //using Microsoft.Crm.Sdk.Helper;

    public interface IModelsFrmLogon : ISuperBase
    {
        Boolean SaveConfig();
        void RetrieveOrganization();
        void GetConfigSaved();
        void SetConfiguration();
        //ServerConnection ServerConnection { get; set; }
        void IsExist();
    }
}