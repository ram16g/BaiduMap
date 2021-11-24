using BaiduMap.Native;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiduMap.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            string baseUrl = DependencyService.Get<IBaseUrl>().Get();
            webView.Source = baseUrl + "index.html";
        }
    }
}