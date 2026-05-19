using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamingTablesBookingProject.Models
{
    [Table("Bookings")]
    public class Booking
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("User")]
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("GameTable")]
        [Column("table_id")]
        public int TableId { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("time_start")]
        public TimeSpan TimeStart { get; set; }

        [Column("time_end")]
        public TimeSpan TimeEnd { get; set; }

        [Required]
        [Column("status")]
        public string Status { get; set; } = "Active";

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        public virtual User? User { get; set; }
        public virtual GameTable? GameTable { get; set; }
    }
}