using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using PraductShop_WPF.Models;
namespace PraductShop_WPF;
public partial class Shoping : Window
{
    public ObservableCollection<Product> SelectProduct { get; set; }

    public Shoping()
    {
        InitializeComponent();
        DataContext = this;
    }



}

