using PraductShop_WPF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
namespace PraductShop_WPF;

public partial class MainWindow : Window
{
    public ObservableCollection<Product> Praducts { get; set; }
    public ObservableCollection<Product> SelectedProducts { get; set; }

    string? fileName = "AllProduct.json";
    public MainWindow()
    {
        Praducts = new()
        {
            new Product {Name="Kişi Eynək Gümüş" , Price = 38 , Image="Images/KisiEynek.png" },
            new Product {Name="Kişi Eynək Qizili" , Price = 38 , Image="Images/KisiEynekQizili.png" },
            new Product {Name="Kişi Eynək Ray-Ban" , Price = 38 , Image="Images/KisiEynekrayban.png" }
        };
        InitializeComponent();
        DataContext = this;
    }

    private void AddShoping_click(object sender, RoutedEventArgs e)
    {
        
        
    }

    private void Basket_Click(object sender, RoutedEventArgs e)
    {
        Shoping shoping = new();
        Hide();
        shoping.ShowDialog();
        Show();
    }

    private void AddProduct_Click(object sender, RoutedEventArgs e)
    {
        AddPraduct addPraductWindow = new();
        Hide();
        addPraductWindow.ShowDialog();
        Show();
    }
}
