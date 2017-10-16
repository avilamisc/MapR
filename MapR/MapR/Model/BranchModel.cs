using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;

namespace MapR.Model
{
  /// <summary>
  /// Clase que representa una sucursal
  /// </summary>

  [DataContract]
  public class BranchModel : INotifyPropertyChanged
  {
    [DataMember(Name = "SUC_NAME")]
    private string sucName;
    public string SucName
    {
      get { return sucName; }
      set { sucName = value; }
    }
    [DataMember(Name = "SUC_ADRESS")]
    private string sucAdress;
    public string SucAdress
    {
      get { return sucAdress; }
      set { sucAdress = value; }
    }

    [DataMember(Name = "ESTADO")]
    private string estado;
    public string Estado
    {
      get { return estado; }
      set { estado = value; }
    }

    [DataMember(Name = "CP")]
    private int cp;
    public int Cp
    {
      get { return cp; }
      set { cp = value; }
    }

    [DataMember(Name = "PHONE")]
    private string phone;
    public string Phone
    {
      get { return phone; }
      set { phone = value; }
    }

    [DataMember(Name = "LAT")]
    public double Lat { get; set; }

    [DataMember(Name = "LON")]
    public double Lon { get; set; }

    [DataMember(Name = "ID_COUNTRY")]
    private string idCountry;
    [DataMember]
    public string IdCountry
    {
      get { return idCountry; }
      set { idCountry = value; }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string sucursalNombre = "")
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(sucursalNombre));
    }
  }
}
