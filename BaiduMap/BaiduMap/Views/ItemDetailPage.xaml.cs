using BaiduMap.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BaiduMap.Views
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