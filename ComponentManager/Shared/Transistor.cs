using System.ComponentModel.DataAnnotations;

namespace ComponentManager.Shared
{
    public class Transistor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int? UMax { get; set; }



    }
}