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
        public int AddAccount(AccountTG accountTG);
        public AccountTG GetAccount(int idAccount);
        public List<AccountTG> GetListAccount(int idAccount);
        public int UpdateAccount(AccountTG accountTG);
        public int DeleteAccount(int idAccount);

        public int AddNumber(int idAccount, PhoneNumber phoneNumber);
        public PhoneNumber GetNumber(int idNumber);
        public List<PhoneNumber> GetNumbersUser(int idAccount);
        public int UpdateNumber(int idNumber, PhoneNumber number);
        public int DeleteNumber(int idNumber);

        public int AddMail(int idAccount, Mail mail);
        public Mail GetMail(int idMail);
        public List<Mail> GetMailsUser(int idAccount);
        public int UpdateMail(int idMail, Mail mail);
        public int DeleteNumber(int idMail);
    }
}