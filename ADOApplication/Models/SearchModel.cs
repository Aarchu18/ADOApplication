namespace ADOApplication.Models
{
    public class SearchModel
    {
        public string SearchText { set; get; }
        public int ProductCategoryId { set; get; }
        public int MinRange { set; get; }
        public int MaxRange { set; get; }
    }
}
