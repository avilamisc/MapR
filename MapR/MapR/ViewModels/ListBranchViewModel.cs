using MapR.Model;
using System.Linq;
using MapR.Services;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MapR.ViewModels
{
    public class ListBranchViewModel : INotifyPropertyChanged
    {
        private List<BranchModel> branches;
        public List<BranchModel> Branches
        {
            get { return branches; }
            set
            {
                branches = value;
                OnPropertyChanged();
            }
        }

        public ListBranchViewModel()
        {
            LoadService();
        }

        private async Task LoadService()
        {
            ServiceBranchs serv = new ServiceBranchs();
            var bran = await serv.GetAllBranchAsync();
            Branches = bran.ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
