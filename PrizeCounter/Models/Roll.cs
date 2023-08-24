namespace PrizeCounter.Models;
    
public static class Roll {

  static readonly Random rand = new Random();
  
  public static bool Perform() {
    int val = rand.Next(1,6);   // (inclusive, exclusive)
    if (val == 1) {
      return true;
    }
    else {
      return false;
    }
  } 


}


