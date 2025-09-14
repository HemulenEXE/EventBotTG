using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBotTG.DBLogic.Entity
{
    public class AccountTG
    {
        public AccountTG(string fName, string tName, string uChat, string uUser)
        {
            fullName = fName;
            tagName = tName;
            uuidChat = uChat;
            uUser = uUser;
        }
        
        int idAccount;

        string fullName;

        string tagName;

        string uuidChat;

        string uuidUser;
    }
}