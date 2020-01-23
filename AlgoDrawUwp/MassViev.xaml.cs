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
using Windows.UI.Xaml.Shapes;

// Документацию по шаблону элемента "Пользовательский элемент управления" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234236

namespace AlgoDrawUwp
{
    public sealed partial class MassViev : UserControl
    {
        private List<float> _array;
        public List<float> Array
        {
            get { return _array; }
            set
            {
                _array = value;
                foreach (float f in value)
                    view.Items.Add(new ValueForArray(f));
            }
        }
        public MassViev()
        {
            this.InitializeComponent();
            Array = new List<float>() { 100, 10, 20 };
        }
    }
}
public class ValueForArray
{
    public float value { get; set; }
    public ValueForArray(float a) { value = a; }
}