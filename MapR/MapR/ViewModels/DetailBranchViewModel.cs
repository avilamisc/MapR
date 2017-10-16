using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MapR.ViewModels
{
  /// <summary>
  /// Clase que gestiona el manejo de información con respecto al detalle de la sucursal
  /// </summary>
  public class DetailBranchViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string property = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
  }
}
