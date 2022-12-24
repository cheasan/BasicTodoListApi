namespace BasicToDoListApi.Models.Entities
{
    public class Category : BaseEntity
    {
        public string Title { get; set; } = "";
        public string Icon { get; set; } = "";
        public ICollection<ItemList> Lists { get; set; }
    }
}