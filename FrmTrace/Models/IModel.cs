using DeXrm.Win.Object;

namespace DeXrm.Win.Tools.Models
{
    public interface IModelTrace
    {
        RegeditObject RegeditObject { get; set; }
        void ChangeRegedit();
    }
}