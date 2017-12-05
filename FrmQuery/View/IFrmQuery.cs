//using Microsoft.Crm.Sdk.Helper;

namespace DeXrm.Win.Tools
{
    public interface IFrmQuery
    {
        void setController(IControllerFrmQuery cont);
        void SetEntities(IModelFrmQuery model);

        void Message();
        //ServerConnection ServerConnection { get; set; }
    }
}