using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBotTG.DBLogic.Entity;
using EventBotTG.DBLogic;

namespace EventBotTG.DBLogic.Interface
{
    public interface IRepository
    {
        public void AddAccount(AccountTG accountTG);
        public void GetAccount(int idAccount);

        public List<AccountTG> GetListAccount(int idAccount);

        public void UpdateAccount(AccountTG accountTG);

        public void DeleteAccount(int idAccount);

        public void AddNumber(int idAccount, PhoneNumber phoneNumber);

        public void UpdateNumber(int idNumber, string number);

        public void DeleteNumber(int idNumber);
    }
}