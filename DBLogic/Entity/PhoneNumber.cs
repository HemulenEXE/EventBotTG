using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBotTG.DBLogic.Entity
{
    public class PhoneNumber
    {
        int idNumber;
        string phoneNumber;

        public PhoneNumber(string pNumber)
        {
            this.phoneNumber = pNumber;
        }
    }
}