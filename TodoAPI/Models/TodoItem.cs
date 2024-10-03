namespace TodoAPI.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string? Name { get; set; }
        public bool isComplete { get; set; }
        public string? Secret { get; set; }
    }
}
