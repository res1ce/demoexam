using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

public class Partner : INotifyPropertyChanged
{
    private string _companyName;
    private string _type;
    private int _rating;

    [Key]
    public int PartnerId { get; set; }

    public string Type
    {
        get => _type;
        set { _type = value; OnPropertyChanged(nameof(Type)); }
    }

    public string CompanyName
    {
        get => _companyName;
        set { _companyName = value; OnPropertyChanged(nameof(CompanyName)); }
    }

    public int Rating
    {
        get => _rating;
        set { _rating = value; OnPropertyChanged(nameof(Rating)); }
    }

    public string DirectorName { get; set; }
    public string Phone { get; set; }
    public string Inn { get; set; }
    public string Email { get; set; }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
