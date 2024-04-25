using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PraductShop_WPF.Models;

public class ProductBox : INotifyPropertyChanged
{
	public Product? Product { get; set; }

	private int count;

	public int Count
	{
		get { return count; }
		set { count = value; OnPropertyRaised(); }
	}

    private double total;

    public double Total
    {
        get { return total; }
        set { total = value; OnPropertyRaised(); }
    }

    public ProductBox(Product product)
    {
        Product = product;
        Count = 1;
        Total = Total;
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyRaised([CallerMemberName] string? name = null)
    {
        if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
    }
}
