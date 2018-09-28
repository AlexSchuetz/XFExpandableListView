
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFExpandableListViewSample.ViewModels;

namespace XFExpandableListViewSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpandableListView : ContentView
    {
        public ExpandableListView()
        {
            InitializeComponent();
            BindingContext = new ExpandableListViewPageViewModel();
        }
    }
}