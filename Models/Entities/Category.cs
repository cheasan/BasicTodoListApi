namespace BasicToDoListApi.Models
{
    public class Category : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Icon { get; set; } = "";
        public ICollection<List> Lists { get; set; }
    }
}