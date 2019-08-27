using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yoisho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
    }
}