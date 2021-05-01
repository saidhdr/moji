using System;

using Moji.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Moji.Views
{
    public sealed partial class Blank2Page : Page
    {
        public Blank2ViewModel ViewModel { get; } = new Blank2ViewModel();

        public Blank2Page()
        {
            InitializeComponent();
        }
    }
}
