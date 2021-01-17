using System;

using UWPTemplatePrism.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplatePrism.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel => DataContext as ImageGalleryViewModel;

        public ImageGalleryPage()
        {
            InitializeComponent();
        }
    }
}
