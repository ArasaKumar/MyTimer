using System;
using System.IO;
using System.Windows.Forms;
using Timer.Interfaces;

namespace Timer
{
    class SaveToFile : ISaveData
    {

        public bool SaveData(DateTime pdtmeTodayDate, string[] pstraData, IExceptionHandler pExHandler, out string pstrMessage)
        {
            try
            {
                string strFileName = GetFileName(pdtmeTodayDate);
                File.WriteAllLines(strFileName, pstraData);
                pstrMessage = "Saved successfully!";
                Clipboard.SetText(strFileName);
                return true;
            }
            catch(Exception ex)
            {
                pExHandler.HandleException(ex);
                pstrMessage = $"Exception Occured: {ex}";
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
