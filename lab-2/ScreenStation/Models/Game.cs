using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScreenStation.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Developer> Developers { get; set; }

        public List<Platform> Platforms { get; set; }
    }
}