using System;
using System.Windows.Forms;
using Timer.Interfaces;

namespace Timer.ExceptionHandler
{
    class ExceptionHandler : IExceptionHandler
    {
        public void HandleException(Exception pEx)
        {
            MessageBox.Show(pEx.ToString(), Constants.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
