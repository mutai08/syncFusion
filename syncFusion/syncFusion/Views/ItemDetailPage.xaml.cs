using syncFusion.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace syncFusion.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}