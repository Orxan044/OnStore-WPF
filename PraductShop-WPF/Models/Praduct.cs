using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PraductShop_WPF.Models;

public class Product : INotifyPropertyChanged
{
    private string? image;

    public string Image
    {
        get { return image; }
        set { image = value; OnPropertyRaised(); }
    }

    private string? name;

    public string? Name
    {
        get { return name; }
        set { name = value; OnPropertyRaised(); }
    }

    private double price;

    public double Price
    {
        get { return price; }
        set { price = value; OnPropertyRaised(); }
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyRaised([CallerMemberName] string? name = null)
    {
        if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}
