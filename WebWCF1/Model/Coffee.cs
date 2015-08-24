using System.ComponentModel.DataAnnotations;

namespace WebWCF1.Model
{
    public class Coffee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Volume { get; set; }

    }
}