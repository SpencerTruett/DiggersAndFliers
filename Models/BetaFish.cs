using System;

namespace diggersAndFliers
{
  public class BetaFish : ISwimmers
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Swimmer { get; set; }
  }
}