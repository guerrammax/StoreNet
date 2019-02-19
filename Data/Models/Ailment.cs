using System.ComponentModel.DataAnnotations;

namespace StoreNet.Data.Models
{
    public class Ailment
    {
         [Key]
        public string Name { get; set; }
    }
}