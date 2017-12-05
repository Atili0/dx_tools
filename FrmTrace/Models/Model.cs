using DeXrm.Win.Datos;
using DeXrm.Win.Object;

namespace DeXrm.Win.Tools.Models
{
    public class ModelTrace : IModelTrace
    {
        public void ChangeRegedit()
        {
            new RegeditData().ChangeRegedit(RegeditObject);
        }

        public RegeditObject RegeditObject { get; set; }
    }
}