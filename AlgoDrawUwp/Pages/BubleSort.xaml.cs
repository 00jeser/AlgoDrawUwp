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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace AlgoDrawUwp.Pages
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BubleSort : Page
    {
        public BubleSort()
        {
            this.InitializeComponent();
            code.Text = "mass = [ 0, 20, 100, 35, 84, 99 ]\nfor i in range(len(mass) // 2):\n\tmass[i], mass[-i - 1] = mass[-i - 1], mass[i]\nprint(mass)";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
