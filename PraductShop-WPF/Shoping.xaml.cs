using System.Collections.ObjectModel;
using System.Windows;
using PraductShop_WPF.Models;
namespace PraductShop_WPF;
public partial class Shoping : Window
{
<<<<<<< HEAD
    public ObservableCollection<Basket> Basket { get; set; }

    public Shoping(ObservableCollection<Basket> Basket)
    {
        InitializeComponent();
        this.Basket = Basket;
=======
    public ObservableCollection<Product> Basket { get; set; } = new();
    public Shoping()
    {
        InitializeComponent();
>>>>>>> a28e7851a93052bbfdc43dcc8915a20f10ffa235
        DataContext = this;
    }

    private void BuyProducts_Clik(object sender , RoutedEventArgs e)
    {
        double TotalPrice = 0;

        foreach (var item in Basket)        
            TotalPrice += item.Product!.Price;

        if (TotalPrice != 0)
        {

            MessageBoxResult result = MessageBox.Show($"Buy Products Total = {TotalPrice} ??", "Buy Products", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Good luck !");
                ((MainWindow)Application.Current.MainWindow).BasketShop = new();
            }
            Close();
        }
        else  MessageBox.Show("Null Basket !!!");
    }

    private void ClearProducts_Click(object sender , RoutedEventArgs e)
    {
        ((MainWindow)Application.Current.MainWindow).BasketShop = new();
        Close();
    }




}

