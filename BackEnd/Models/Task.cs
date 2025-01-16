namespace BackEnd.Models
{
    public class Task
    {
        public required int id {get; set;}
        public required string title {get; set;}
        public bool completed {get; set;}
        public DateTime createdAt {get; set;}
    }
}