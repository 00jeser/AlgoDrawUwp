using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
    public sealed partial class RevertAlgo : Page
    {

        public RevertAlgo()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            massView.Array = new List<float>();
            //var t = new Thread(revert);
            //t.Start((object)massView);
        }

        private void revert(object obj)
        {
            var mass = (obj as MassViev).Array;
            (obj as MassViev).Array = new List<float>() { 0, 1, 2, 3, 6, 4, 5 };
            Thread.Sleep(1000);
            (obj as MassViev).Array = new List<float>() { 0, 1, 2, 3, 4, 5, 6 };
        }
    }
}
