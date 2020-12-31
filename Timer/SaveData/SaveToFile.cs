using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Interfaces;
using System.IO;
using System.Windows.Forms;

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
