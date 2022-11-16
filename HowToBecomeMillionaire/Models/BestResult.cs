using System.ComponentModel.DataAnnotations;

namespace HowToBecomeMillionaire.Models
{
    public class BestResult
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Result { get; set; }
        public int GameModeId { get; set; }
    }
}
