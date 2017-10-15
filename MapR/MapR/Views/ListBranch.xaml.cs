using Xamarin.Forms;
using MapR.ViewModels;
using Xamarin.Forms.Xaml;

namespace MapR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListBranch : ContentPage
    {
        public ListBranch()
        {
            InitializeComponent();
            BindingContext = new ListBranchViewModel();
        }
    }
}