using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalDataSecurity.BLL.Models;

namespace PersonalDataSecurity.BLL.Services.AccountAuth
{
    class MessageBroker
    {
        public void ReceivingMessage(AuthStruct model)
        {
            
        }
        
        public AuthStatus RetrievedMessage()
        {
            return AuthStatus.authorized;
        }
    }

    enum AuthStatus
    {
        notAuthorized,
        authorized
    }
}
