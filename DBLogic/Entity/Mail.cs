using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBotTG.DBLogic.Entity : AbstractTypeCommunity
{
    public class Mail : AbstractTypeCommunity
    {
        int idMail;

        int idOwner;

        string mail;
        
        public Mail(string mail, int idOwner)
        {
            this.mail = mail;
            this.idOwner = idOwner;
        }

        public override string GetDataConnect()
        {
            return mail;
        }
        
        
    }
}