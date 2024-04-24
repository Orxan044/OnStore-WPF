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
            new Product {Name="Kişi Eynək Gümüş" , Price = 38 , Image="Images/KisiEynek.png" }
        };

        //try
        //{
        //    if (File.Exists(fileName))
        //    {
        //        var read = File.ReadAllText(fileName);
        //        var jsonProduct = JsonSerializer.Deserialize<ObservableCollection<Product>>(read);
        //        foreach (var item in jsonProduct)
        //            Praducts.Add(item);
        //    }
        //}
        //catch (System.Exception)
        //{
        //    MessageBox.Show("File Eror");

        //}
        InitializeComponent();
        DataContext = this;
    }

    private void AddShoping_click(object sender, RoutedEventArgs e)
    {
        
        
    }

    private void AddProduct_Click(object sender, RoutedEventArgs e)
    {
        //Close();
        AddPraduct addPraductWindow = new();
        addPraductWindow.ShowDialog();
        //Show();
    }
}
