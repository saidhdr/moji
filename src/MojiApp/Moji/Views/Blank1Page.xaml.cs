using System;

using Moji.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Moji.Views
{
    public sealed partial class Blank1Page : Page
    {
        public Blank1ViewModel ViewModel { get; } = new Blank1ViewModel();

        public Blank1Page()
        {
            InitializeComponent();
        }
    }
}
