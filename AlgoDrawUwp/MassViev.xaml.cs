using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

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
                view.Items.Clear();
                _array = value;
                foreach (float f in value)
                    view.Items.Add(new ValueForArray(f));
            }
        }
        public MassViev()
        {
            this.InitializeComponent();
        }
    }
}
public class ValueForArray
{
    public float value { get; set; }
    public SolidColorBrush color => new SolidColorBrush(Color.FromArgb(255, (byte)value, 0, (byte)value));
    public ValueForArray(float a) { value = a; }
}