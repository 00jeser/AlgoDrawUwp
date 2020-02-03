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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace AlgoDrawUwp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AlgoList.Items.Add(new ListViewItem() { Content = "переворот", Tag = new Pages.RevertAlgo() });
            AlgoList.Items.Add(new ListViewItem() { Content = "сотировка пузырьком", Tag = new Pages.BubleSort() });
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AlgoPage.Content = ((sender as ListView).SelectedItem as ListViewItem).Tag;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            splitV.IsPaneOpen = !splitV.IsPaneOpen;
        }
    }
}
