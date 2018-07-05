using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAuthentication.DTO
{

    /// <summary>
    /// This Data Transfer Object is used to Transfer the data between Model and presentation layer.
    /// </summary>
    public class RegisterCBAUserRequestDTO 
    {
        public ApplicationType AppID { get; set; }
        public int UserID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// It describes the Application Type of each Application.
    /// </summary>
    public enum ApplicationType
    {
        Undefined = 0,
        AdminApplication = 1,
        BenefitAccess = 2,
        CorpBenefitAccess = 3,
        ClientServ = 4
    }

}
