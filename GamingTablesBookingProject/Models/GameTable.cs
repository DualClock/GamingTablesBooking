using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamingTablesBookingProject.Models
{
    [Table("Tables")]
    public class GameTable
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("capacity")]
        public int Capacity { get; set; }

        [StringLength(50)]
        [Column("status")]
        public string Status { get; set; } = "available";
    }
}