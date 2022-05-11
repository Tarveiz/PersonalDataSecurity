using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalDataSecurity.BLL.Services.AccountAuth;
using PersonalDataSecurity.BLL.Models;

namespace PersonalDataSecurity.DAL.Services.Front
{
    public partial class FrontForms : Form
    {
        public FrontForms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            MessageBroker message = new MessageBroker();
            AuthStruct model = new AuthStruct(login, password);
            message.ReceivingMessage(model);
        }
    }
}
