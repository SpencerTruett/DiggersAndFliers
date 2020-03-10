using System;

namespace diggersAndFliers
{
  public class Parakeets : IFliers
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Flier { get; set; }
  }
}