using System;

using Moji.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Moji.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; } = new BlankViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
