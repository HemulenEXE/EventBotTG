using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventBotTG.DBLogic.Entity;
using EventBotTG.DBLogic;

namespace EventBotTG.DBLogic.Interface
{
    public interface IDBInitializer
    {
        public void InitDB(string connectDB);

        public void InitScheme();

        public void InitAccountTGTable();

        public void InitMailTable();

        public void InitPhoneNumberTable();

        public void InitView();

        public void InitProcedure();

        public void InitFunction();

        public void InitTriggers();
    }
}