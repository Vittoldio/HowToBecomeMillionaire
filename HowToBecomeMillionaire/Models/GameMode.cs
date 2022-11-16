using System.ComponentModel.DataAnnotations;

namespace HowToBecomeMillionaire.Models
{
    public class GameMode
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
