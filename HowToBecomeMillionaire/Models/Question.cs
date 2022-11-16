using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HowToBecomeMillionaire.Models
{
    public class Question
    {

        [Key]
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public int CorrectAnswer { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string? ImageName { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
