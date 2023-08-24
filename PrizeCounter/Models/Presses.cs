namespace PrizeCounter.Models;

public class Presses {

  private static int TotalCount = 0;
  public string CountMsg => $"Total Presses: {TotalCount}"; 

  public Presses() {}

  public void Press() {
    ++TotalCount;
  }

}
