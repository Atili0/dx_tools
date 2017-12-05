using DeXrm.Win.Datos;
using DeXrm.Win.Object;
using Configuration = DeXrm.Win.Object.Configuration;

namespace DeXrm.Win.Tools.Models
{
    //using Microsoft.Crm.Sdk.Helper;

    public class ModelsFrmImport : SuperBase, IModelsFrmImport
    {
        public bool SaveConfig()
        {
            var obj = SetObject(this);
            Datos.Configuration.SaveConfiguration(obj);
            return true;
        }

        public void SetConfiguration()
        {
            //this.ServerConnection = OrganizationData.GetObjectConnection(this.Configuration.SavedConfig);
        }

        public void GetConfigSaved()
        {
            File = Util.GetConfigSaved();
        }

        public void RetrieveOrganization()
        {
            OrganizationObjects = new OrganizationData().GetAllOrganization(Configuration.SavedConfig);
            new Util().UpdateConfigFile(Configuration.SavedConfig, OrganizationObjects[0].OrganizationUri.ToString(),
                "Uri");
            new Util().UpdateConfigFile(Configuration.SavedConfig, OrganizationObjects[0].FriendlyName, "Org");
        }

        public void IsExist()
        {
            Exist = new OrganizationData().IsExist(Configuration.SavedConfig);
        }

        private Configuration SetObject(ModelsFrmImport modelsFrm)
        {
            var objConfiguration = new Configuration
            {
                Domain = modelsFrm.Configuration.Domain,
                Password = modelsFrm.Configuration.Password,
                UrlServer = modelsFrm.Configuration.UrlServer,
                User = modelsFrm.Configuration.User,
                TypeConnection = modelsFrm.Configuration.TypeConnection,
                IsTemplate = modelsFrm.Configuration.IsTemplate,
                SavedConfig = modelsFrm.Configuration.SavedConfig,
                IsOnline = modelsFrm.Configuration.IsOnline,
                Organization = modelsFrm.Configuration.Organization,
                InternalUser = modelsFrm.Configuration.InternalUser,
                SecurityUrl = modelsFrm.Configuration.SecurityUrl,
                NameServer = modelsFrm.Configuration.NameServer,
                DefaultUrl = modelsFrm.Configuration.DefaultUrl
            };
            return objConfiguration;
        }

        /// <summary>
        /// Objeto para poder enviarlo al Main
        /// </summary>
        //public ServerConnection ServerConnection { get; set; }  
    }
}