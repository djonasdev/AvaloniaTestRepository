using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaTestRepository.Views.Foo;

namespace AvaloniaTestRepository
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private async void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            var window = new Window
            {
                Content = new FooView()
            };
            await window.ShowDialog(this);
        }
    }
}