using System;

namespace diggersAndFliers
{
  public class Ants : ICrawlers
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Crawler { get; set; }
    public bool Digger { get; set; }
  }
}