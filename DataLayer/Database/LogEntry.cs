using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Database
{
    public class LogEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
    }
}
