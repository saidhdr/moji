﻿using System;
using System.Threading.Tasks;

using Moji.Core.Helpers;

using Windows.UI.Popups;

namespace Moji.Helpers
{
    internal static class AuthenticationHelper
    {
        internal static async Task ShowLoginErrorAsync(LoginResultType loginResult)
        {
            switch (loginResult)
            {
                case LoginResultType.NoNetworkAvailable:
                    await new MessageDialog(
                        "DialogNoNetworkAvailableContent".GetLocalized(),
                        "DialogAuthenticationTitle".GetLocalized()).ShowAsync();
                    break;
                case LoginResultType.UnknownError:
                    await new MessageDialog(
                        "DialogStatusUnknownErrorContent".GetLocalized(),
                        "DialogAuthenticationTitle".GetLocalized()).ShowAsync();
                    break;
            }
        }
    }
}
