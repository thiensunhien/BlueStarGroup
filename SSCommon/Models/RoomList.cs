using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSCommon.Models
{
    [Table("RoomList")]
    public class RoomList
    {
        [Key]
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public string FloorID { get; set; }
        public string RoomType { get; set; }
        public decimal HourPrice { get; set; }
        public decimal DayPrice { get; set; }
        public int Status { get; set; }
    }
}
