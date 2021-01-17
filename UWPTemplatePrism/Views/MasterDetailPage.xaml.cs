using System;

using Microsoft.Toolkit.Uwp.UI.Controls;

using UWPTemplatePrism.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplatePrism.Views
{
    public sealed partial class MasterDetailPage : Page
    {
        private MasterDetailViewModel ViewModel => DataContext as MasterDetailViewModel;

        public MasterDetailPage()
        {
            InitializeComponent();
        }
    }
}
