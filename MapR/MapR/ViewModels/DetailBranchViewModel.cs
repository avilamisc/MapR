using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MapR.ViewModels
{
    public class DetailBranchViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
