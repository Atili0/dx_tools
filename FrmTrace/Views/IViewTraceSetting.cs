using DeXrm.Win.Object;
using DeXrm.Win.Tools.Controllers;

namespace DeXrm.Win.Tools.Views
{
    public interface IViewTraceSetting
    {
        bool IsAvaibleTrace { get; set; }
        string PathLog { get; set; }
        RegeditObject RegeditObject { get; set; }
        void SetController(IControllersFrmTrace cont);
    }
}