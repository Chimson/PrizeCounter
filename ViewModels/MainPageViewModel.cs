namespace PrizeCounter.ViewModels;

using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;   
using PrizeCounter.Views;
using PrizeCounter.Models;

class MainPageViewModel : ObservableObject {

  public ICommand RollForPrizeCommand {get; private set;}
  public string Msg {get; private set;} 
  private static Presses press_obj = new Presses();

  public MainPageViewModel() {
    RollForPrizeCommand = new AsyncRelayCommand(RollForPrize);
  }

  private async Task RollForPrize() {
    
    press_obj.Press();

    Msg = press_obj.CountMsg;
    
    OnPropertyChanged(nameof(Msg));

    if (Models.Roll.Perform()) {
      await Shell.Current.GoToAsync($"{nameof(Views.WinPage)}");
    }
    else {
      await MainPage.Ref.DisplayAlert("", "Please Try Again!", "OK");
    }
  }

}

