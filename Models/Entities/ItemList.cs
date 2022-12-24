namespace BasicToDoListApi.Models.Entities
{
    public class ItemList : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Title { get; set; } = "";
        public string Status { get; set; } = "NEW";
        public bool IsFavorite { get; set; }
        public string[]? Attachements { get; set; }
        public string Note { get; set; } = "";
        public virtual Category Category { get; set; }
        public ICollection<SubList> SubLists { get; set; }
    }
}