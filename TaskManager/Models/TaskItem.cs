using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Display(Name = "Is completed?")]
        public bool IsCompleted { get; set; }
    }
}
