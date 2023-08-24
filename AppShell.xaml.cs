namespace PrizeCounter;

public partial class AppShell : Shell {
	
  public AppShell() {
		InitializeComponent();

    // since WinPage is not in the ShellContent in AppShell.xaml
    Routing.RegisterRoute(nameof(Views.WinPage), typeof(Views.WinPage));

	}
  
}
