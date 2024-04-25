using System.Collections.ObjectModel;
using System.Windows;
using PraductShop_WPF.Models;
namespace PraductShop_WPF;
public partial class Shoping : Window
{
    public ObservableCollection<Product> SelectedItems { get; set; }
    public Shoping(ObservableCollection<Product> ShopList)
    {
        InitializeComponent();
        SelectedItems = ShopList;
        DataContext = this;
    }



}

