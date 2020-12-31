using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Timer
{
    public class DataStore : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static DataStore _objDataStore = new DataStore();
        private Dictionary<string, TimeSpan> _dicAppAndTime = new Dictionary<string, TimeSpan>();
        private DateTime _dtmeFocusObtainedTime = DateTime.Now;
        private string _strCurrentApp = string.Empty;

        public static DataStore GetInstance()
        {
            return _objDataStore;
        }

        private DataStore()
        {

        }

        public string[] Data
        {
            get
            {
                List<string> lstData = new List<string>();
                foreach(KeyValuePair<string,TimeSpan> kv in _dicAppAndTime)
                {
                    lstData.Add( kv.Key + " : " + kv.Value);
                }
                return lstData.ToArray();
            }
        }

        public void UpdateData(string pstrData)
        {
            UpdateTimings(pstrData);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AppList"));
            _dtmeFocusObtainedTime = DateTime.Now;
        }

        private void UpdateTimings (string pstrAppName)
        {
            if(_dicAppAndTime.ContainsKey(pstrAppName))
            {
                _dicAppAndTime[_strCurrentApp] = _dicAppAndTime[_strCurrentApp] + (DateTime.Now - _dtmeFocusObtainedTime);
            }
            else
            {
                _dicAppAndTime.Add(pstrAppName, new TimeSpan());
            }
            _strCurrentApp = pstrAppName;
        }
    }
}

