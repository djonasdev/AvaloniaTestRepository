using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace AvaloniaTestRepository.Views.Foo
{
    public partial class FooView : UserControl
    {
        public FooView()
        {
            InitializeComponent();

            Dispatcher.UIThread.InvokeAsync(() =>
            {
                this.GetVisualDescendants().OfType<TextBox>().FirstOrDefault(x => string.IsNullOrEmpty(x.Text))
                    ?.Focus();
            }, DispatcherPriority.Loaded);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}