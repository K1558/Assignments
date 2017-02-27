using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace teht1._3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        int t = 0;
        private void Truck_button_Click(object sender, RoutedEventArgs e)
        {

            t++;
            string truck = t.ToString();
            
            Truck_counter.Text = truck;
        }

        int c = 0;
        private void Car_button_Click(object sender, RoutedEventArgs e)
        {
            c++;
            string car = c.ToString();

            Car_counter.Text = car;
        }
    }
}
