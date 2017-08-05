using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicAuthentication.Models
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}