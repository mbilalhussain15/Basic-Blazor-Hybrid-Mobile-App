namespace SampleProject1;

public partial class App : Application
{
    private readonly SeedDataService _seedDataService;

    public App(SeedDataService seedDataService,AppViewModel appViewModel)
	{
		InitializeComponent();

		MainPage = new MainPage(appViewModel);
        _seedDataService = seedDataService;
    }

    protected override async void OnStart()
    {
        base.OnStart();
        await _seedDataService.SeedDataAsync();
    }
}
