using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VehicleRental;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        string[] Categories = ["Category1", "Category2", "Category3"];
        foreach (string category in Categories)
        {
            CategoryComboBox.Items.Add(category);
            PickUpComboBox.Items.Add(category);
            LocationComboBox.Items.Add(category);
            PickUpComboBox.Items.Add(category);
        }
    }
}