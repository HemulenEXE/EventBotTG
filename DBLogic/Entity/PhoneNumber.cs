using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBotTG.DBLogic.Entity
{
    public class PhoneNumber : AbstractTypeCommunity
    {
        int idNumber;

        int idOwner;
        
        string phoneNumber;

        public PhoneNumber(string pNumber, int idOwner)
        {
            this.phoneNumber = pNumber;
            this.idOwner = idOwner;
        }

        public override string GetDataConnect()
        {
            return phoneNumber;
        }
    }
}