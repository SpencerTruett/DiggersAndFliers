using System;
using System.Collections.Generic;

namespace diggersAndFliers
{
  public class Containers
  {
    // Lists of Animals
    public List<Ants> Ants = new List<Ants>();
    public List<BetaFish> BetaFish = new List<BetaFish>();
    public List<Copperhead> Copperhead = new List<Copperhead>();
    public List<Earthworms> Earthworms = new List<Earthworms>();
    public List<Finches> Finches = new List<Finches>();
    public List<Gerbils> Gerbils = new List<Gerbils>();
    public List<Mice> Mice = new List<Mice>();
    public List<Parakeets> Parakeets = new List<Parakeets>();
    public List<Rattlesnake> Rattlesnake = new List<Rattlesnake>();
    public List<Terrapins> Terrapins = new List<Terrapins>();

    // Lists of animals added to Containers 

    // Container of Diggers 
    public List<IDiggers> AddToDiggerCage()
    {
      List<IDiggers> DiggerContainer = new List<IDiggers>();
      DiggerContainer.Add(new Earthworms());
      DiggerContainer.Add(new Gerbils());
      DiggerContainer.Add(new Mice());

      return DiggerContainer;
    }

    // Container of Fliers
    public List<IFliers> AddToFlierCage()
    {
      List<IFliers> FlierContainer = new List<IFliers>();
      FlierContainer.Add(new Finches());
      FlierContainer.Add(new Parakeets());

      return FlierContainer;
    }

    // Container of Swimmers
    public List<ISwimmers> AddToSwimmerCage()
    {
      List<ISwimmers> SwimmerContainer = new List<ISwimmers>();
      SwimmerContainer.Add(new BetaFish());
      SwimmerContainer.Add(new Terrapins());

      return SwimmerContainer;
    }

    // Container of Crawlers
    public List<ICrawlers> AddToCrawlerCage()
    {
      List<ICrawlers> CrawlerContainer = new List<ICrawlers>();
      CrawlerContainer.Add(new Rattlesnake());
      CrawlerContainer.Add(new Copperhead());
      CrawlerContainer.Add(new Ants());

      return CrawlerContainer;
    }

  }
}