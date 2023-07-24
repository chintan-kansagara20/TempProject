using EasyCrudLibrary.Model;

namespace Models
{
    public class FullGetModel
    {
        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public List<OrderByModel>? orderBy { get; set; }
        public List<AdvanceFilterByModel>? filtersList { get; set; }
    }
}
