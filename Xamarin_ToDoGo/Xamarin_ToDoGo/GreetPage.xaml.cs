using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_ToDoGo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.001;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format($"{e.NewValue:P0}");
        }
    }
}