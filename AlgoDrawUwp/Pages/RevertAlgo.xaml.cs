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
using System.Threading.Tasks;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace AlgoDrawUwp.Pages
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class RevertAlgo : Page
    {
        public List<float> MassHowNeedPrint = new List<float>() { 0f, 20f, 100f, 35f, 84f, 99f };
        private DispatcherTimer timer;

        public RevertAlgo()
        {
            this.InitializeComponent();
            code.Text = "mass = [ 0, 20, 100, 35, 84, 99 ]\nfor i in range(len(mass) // 2):\n\tmass[i], mass[-i - 1] = mass[-i - 1], mass[i]\nprint(mass)";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MassHowNeedPrint = new List<float>() { 0f, 20f, 100f, 35f, 84f, 99f };
            timer?.Stop();
            mass.Array = new List<float>();
            //var t = new Thread(revert);
            //t.Start((object)mass.Array);
            timer = new DispatcherTimer() { Interval = new TimeSpan(0, 0, 0, 0, (int)timeSlider.Value) }; // 1 секунда
            a = 0;
            timer.Tick += revert;
            timer.Tick += (object senderr, object ee) => a++;
            mass.Array = MassHowNeedPrint;
            timer.Start();
        }

        int a = 0;

        private void revert(object sender, object e)
        {
            if (a < 3)
            {
                var tmp = MassHowNeedPrint[a];
                MassHowNeedPrint[a] = MassHowNeedPrint[MassHowNeedPrint.Count - a - 1];
                MassHowNeedPrint[MassHowNeedPrint.Count - a - 1] = tmp;
                mass.Array = MassHowNeedPrint;
            }
        }
    }
}
