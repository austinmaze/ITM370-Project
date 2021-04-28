using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditDeletePage : ContentPage
    {
        public EditDeletePage()
        {
            InitializeComponent();
        }

        private void Pop_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}