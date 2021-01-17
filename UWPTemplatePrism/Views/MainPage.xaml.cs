using System;

using UWPTemplatePrism.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplatePrism.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
