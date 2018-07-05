using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User.Models
{


    [Table("RegisterCBAUserRequest")]
    public class RegisterCBAUserRequest 
    {
        public int AppID { get; set; }
        [Key]
        public int UserID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }




}
