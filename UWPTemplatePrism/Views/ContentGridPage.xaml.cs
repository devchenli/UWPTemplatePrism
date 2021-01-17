using System;

using UWPTemplatePrism.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplatePrism.Views
{
    public sealed partial class ContentGridPage : Page
    {
        private ContentGridViewModel ViewModel => DataContext as ContentGridViewModel;

        public ContentGridPage()
        {
            InitializeComponent();
        }
    }
}
