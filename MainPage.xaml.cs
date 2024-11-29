namespace SampleProject1;

public partial class MainPage : ContentPage
{
	public MainPage(AppViewModel viewModel)
	{
        InitializeComponent();
		BindingContext = viewModel;
	}
}
