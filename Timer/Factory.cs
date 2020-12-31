using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Interfaces;

namespace Timer
{
    class Factory
    {
        public IExceptionHandler GetExceptionHandler()
        {
            return new ExceptionHandler.ExceptionHandler();
        }

        public ISaveData GetSaveData()
        {
            return new SaveToFile();
        }

        public IDataStore GetDataStore()
        {
            return DataStore.GetInstance();
        }
    }
}
