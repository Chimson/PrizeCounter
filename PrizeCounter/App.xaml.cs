namespace PrizeCounter;

using Microsoft.Maui.Controls;

public partial class App : Application {
	
  public App() {
		InitializeComponent();

		MainPage = new AppShell();
	}

  protected override Window CreateWindow(IActivationState activationState) {
    Window window = base.CreateWindow(activationState);
    window.Height = 750;
    window.Width = 500;
    window.X = 500;
    window.Y = 0; 
    return window;
  }

}
