using System;
using System.IO;
using System.Windows.Forms;
using Timer.Interfaces;

namespace Timer
{
    class SaveToFile : ISaveData
    {

        public bool SaveData(DateTime pdtmeTodayDate, string[] pstraData, IExceptionHandler pExHandler)
        {
            try
            {
                string strFileName = GetFileName(pdtmeTodayDate);
                File.WriteAllLines(strFileName, pstraData);
            }
            catch(Exception ex)
            {
                pExHandler.HandleException(ex);
            }
            return false;
        }

        private string GetFileName(DateTime pdtmeTodayDate)
        {
            string strDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string strFileName = Path.Combine(strDirectory, "TimeLog " + pdtmeTodayDate.ToString("dd-MMM-yyyy") + ".txt");
            return strFileName;
        }
    }
}
