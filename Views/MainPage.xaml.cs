namespace PrizeCounter.Views;

public partial class MainPage : ContentPage {
  
  public static MainPage Ref {get; private set;}

	public MainPage() {
		InitializeComponent();
    Ref = this;
  }


}

