using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length <= 1)
            {
                MessageBox.Show("Опа, комунизъм");
            }
            else
            {
                MessageBox.Show("Здрасти " + txtName.Text + "!\nЧестита първа програма");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Здрасти " + txtName.Text + "!!! \nТова е твоята първа програма на Visual Studio 2012!");
            textBlock1.Text = DateTime.Now.ToString();

        }
    }
}
