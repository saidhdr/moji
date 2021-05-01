using System;

using Moji.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Moji.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
