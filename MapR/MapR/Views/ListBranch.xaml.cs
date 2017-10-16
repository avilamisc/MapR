using Xamarin.Forms;
using MapR.ViewModels;
using Xamarin.Forms.Xaml;

using MapR.Model;

namespace MapR.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListBranch : ContentPage
    {
        public ListBranch()
        {
            InitializeComponent();
            BindingContext = new ListBranchViewModel();

            lstBranchs.ItemSelected += LstBranchs_ItemSelected;
        }

        private void LstBranchs_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           if(e.SelectedItem != null)
            {
                BranchModel modelo = (BranchModel)e.SelectedItem;
                Navigation.PushModalAsync(new DetailBranch(modelo));
            }
        }
    }
}