﻿using System;
using System.Threading.Tasks;

using Microsoft.Toolkit.Uwp.Helpers;

using UWPTemplatePrism.Views;

using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace UWPTemplatePrism.Services
{
    // For instructions on testing this service see https://github.com/Microsoft/WindowsTemplateStudio/blob/release/docs/UWP/features/whats-new-prompt.md
    public class WhatsNewDisplayService : IWhatsNewDisplayService
    {
        private static bool shown = false;

        public async Task ShowIfAppropriateAsync()
        {
            await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(
                CoreDispatcherPriority.Normal, async () =>
                {
                    if (SystemInformation.IsAppUpdated && !shown)
                    {
                        shown = true;
                        var dialog = new WhatsNewDialog();
                        await dialog.ShowAsync();
                    }
                });
        }
    }
}