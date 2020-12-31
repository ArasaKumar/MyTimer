using System.ComponentModel;

namespace Timer.Interfaces
{
    interface IDataStore : INotifyPropertyChanged
    {
        void StoreCurrentFocusedWindow(string pstrData);

        string[] Data { get; }

        void Reset();
    }
}
