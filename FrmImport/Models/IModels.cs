using DeXrm.Win.Object;

namespace DeXrm.Win.Tools.Models
{
    //using Microsoft.Crm.Sdk.Helper;

    public interface IModelsFrmImport : ISuperBase
    {
        bool SaveConfig();
        void RetrieveOrganization();
        void GetConfigSaved();

        void SetConfiguration();

        //ServerConnection ServerConnection { get; set; }
        void IsExist();
    }
}