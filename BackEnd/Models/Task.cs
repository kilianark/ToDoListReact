using System.ComponentModel.DataAnnotations;

namespace ToDoListApi.Models
{
    public class Task
    {
        [Key]
        public required int id {get; set;}
        public required string title {get; set;}
        public bool completed {get; set;}
        public DateTime createdAt {get; set;}
    }
}