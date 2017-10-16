using Xamarin.Forms;
using MapR.ViewModels;
using Xamarin.Forms.Xaml;
using MapR.Model;

namespace MapR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailBranch : ContentPage
    {
        public DetailBranch(BranchModel model)
        {
            InitializeComponent();
            BindingContext = new ListBranchViewModel();
            labelSuc.Text = model.SucName;
        }
    }
}