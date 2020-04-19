using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPGXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartScreenPage : ContentPage
    {
        public StartScreenPage()
        {
            InitializeComponent();
        }

        private void GameStartButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainGamePage());
        }

    }
}