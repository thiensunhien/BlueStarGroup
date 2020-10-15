using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSCommon.Models
{
    /// <summary>
    /// User infomation
    /// </summary>
    [Table("Users")]
    public class Users
    {
        [Key]
        public string UserID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public int Permission { get; set; }
    }
}
