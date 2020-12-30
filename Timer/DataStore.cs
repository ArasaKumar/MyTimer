using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Timer
{
    public class DataStore : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<string> _lstAppData = new List<string>();
        private static DataStore _objDataStore = new DataStore();

        public static DataStore GetInstance()
        {
            return _objDataStore;
        }

        private DataStore()
        {

        }

        public string Data
        {
            get
            {
                return string.Join(Environment.NewLine, _lstAppData);
            }
        }

        public void UpdateData(string pstrData)
        {
            _lstAppData.Add(pstrData);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppList"));
        }
    }
}

