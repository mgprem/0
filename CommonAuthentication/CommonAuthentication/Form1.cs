using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using DomainServices;
using CommonAuthentication.DTO;
using CommonAuthentication.Validation;

namespace CommonAuthentication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Register Unity Container
            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<IDBContext, UserDBContext>();
            UserService user = unitycontainer.Resolve<UserService>();


            RegisterCBAUserRequestDTO UserRequestDTO = new RegisterCBAUserRequestDTO();

            // To get input from screen for creating new User record.

            string UserId = txtUserNumber.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string MiddleName = txtMiddleName.Text;
            string Password = txtPassword.Text;


            UserRequestDTO.UserID = Convert.ToInt32(UserId);
            UserRequestDTO.FirstName = firstName;
            UserRequestDTO.LastName = lastName;
            UserRequestDTO.MiddleName = MiddleName;
            UserRequestDTO.Password = "Password";
            UserRequestDTO.AppID = ApplicationType.CorpBenefitAccess;

            user.RegisterCBAUser(UserRequestDTO);
   
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintingSystem client = new PrintingSystem(new UserPrinterHTML());

            //Call to Start method with proper object.
            client.Print(new RegisterCBAUserRequestDTO());
        }
    }
}
