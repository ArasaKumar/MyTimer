using System;
using Timer.Interfaces;

namespace Timer
{
    interface ISaveData
    {
        bool SaveData(DateTime pdtmeTodayDate, string[] pstraData, IExceptionHandler pExHandler,out string pstrMessage);
    }
}
