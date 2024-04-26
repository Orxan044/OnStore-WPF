using System.Collections.ObjectModel;
using System.Windows;
using PraductShop_WPF.Models;
namespace PraductShop_WPF;
public partial class Shoping : Window
{
    public ObservableCollection<Product> Basket { get; set; } = new();
    public Shoping()
    {
        InitializeComponent();
        DataContext = this;
    }



}

