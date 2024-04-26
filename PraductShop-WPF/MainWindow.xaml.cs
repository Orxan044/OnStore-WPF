using PraductShop_WPF.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace PraductShop_WPF;

public partial class MainWindow : Window
{
    public ObservableCollection<Product> Praducts { get; set; }
    Shoping shoping = new();


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
        if (sender is Button button)
        {
            // Parent element of the button is ListBoxItem
            ListBoxItem item = FindAncestor<ListBoxItem>(button);
            if (item != null)
            {
                // Get the DataContext of the ListBoxItem
                var product = item.DataContext as Product;
                if (product != null)
                {
                    shoping.Basket.Add(product);
                }
            }
        }
    }


    public static T FindAncestor<T>(DependencyObject dependencyObject) where T : DependencyObject
    {
        DependencyObject parent = VisualTreeHelper.GetParent(dependencyObject);
        if (parent == null) return null;

        T parentT = parent as T;
        return parentT ?? FindAncestor<T>(parent);
    }

    private void Basket_Click(object sender, RoutedEventArgs e)
    {
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

    private void TextBoxSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
        //listboxShop.Items.Clear();
        //if(txtBoxSearch.Text = )  
    }

    private void PraductChange_MouseDoubleClick(object sender , MouseButtonEventArgs e)
    {
        EditPraduct editPraduct = new();
        Hide();
        editPraduct.ShowDialog();
        Show();
    }
}
