namespace BasicToDoListApi.Models
{
    public class SubList : BaseEntity
    {
        public Guid ListId { get; set; }
        public string Title { get; set; } = "";
        public string Status { get; set; } = "NEW";
        public virtual List List { get; set; }
    }
}