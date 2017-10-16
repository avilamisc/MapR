using MapR.Model;
using Xamarin.Forms;
using MapR.ViewModels;
using Xamarin.Forms.Xaml;

namespace MapR.Views
{
  /// <summary>
  /// Código de la vista del detalle de la sucursal
  /// </summary>
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