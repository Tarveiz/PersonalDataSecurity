using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDataSecurity.DAL.Services.Front;
using System.Windows.Threading;
using System.Windows.Forms;


namespace PersonalDataSecurity.PL.Services.GUI
{
    class AuthForm
    {
        static void Main()
        {
            FrontForms front = new FrontForms();
            Application.Run(front);
        }
    }
}
