using ExamenMvvm.ViewModels;
namespace ExamenMvvm.Views;


public partial class MainView : ContentPage
{

	MainViewModel viewModels;
    public MainView()
	{
		InitializeComponent();
		viewModels = new MainViewModel();
		BindingContext = viewModels;
    }
}