using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPaginaStack(Object sender,EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }
        private void GoPaginaGrid(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }
        private void GoPaginaAbsolute(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }
        private void GoPaginaRelative(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }
        private void GoPaginaScroll(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }


    }
}
