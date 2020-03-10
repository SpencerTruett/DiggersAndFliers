using System;

namespace diggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Parakeets myParakeet = new Parakeets()
            {
                Species = "Budgerigar",
                Name = "Sqawkey",
                Color = "lime green",
                Food = "Fruit and Nuts",
                Flier = true
            };
            Earthworms myEarthworm = new Earthworms()
            {
                Species = "Common Earthworm",
                Name = "Wormy",
                Color = "tan",
                Food = "Dirt",
                Digger = true
            };
            Terrapins myTerrapin = new Terrapins()
            {
                Species = "Southern River Terrapin",
                Name = "Steve",
                Color = "Black",
                Food = "Algae",
                Swimmer = true,
                Crawler = true
            };
            Rattlesnake myRattlesnake = new Rattlesnake()
            {
                Species = "Diamondback Rattlesnake",
                Name = "Bitey",
                Color = "Brown",
                Food = "Mice",
                Crawler = true
            };
            Mice myMouse = new Mice()
            {
                Species = "Deer Mouse",
                Name = "Mr. Wiggles",
                Color = "Tan",
                Food = "Seed and Nuts",
                Digger = true,
                Crawler = true
            };
            Ants myAnt = new Ants()
            {
                Species = "Black Garden Ant",
                Name = "Sgt. Stiggs",
                Color = "Black",
                Food = "Crumbs",
                Crawler = true,
                Digger = true
            };
            Finches myFinch = new Finches()
            {
                Species = "Common Cactus Finch",
                Name = "Gertrude",
                Color = "Black",
                Food = "Worms",
                Flier = true
            };
            BetaFish myBetaFish = new BetaFish()
            {
                Species = "Combtail Betta",
                Name = "Willis",
                Color = "Blue and Purple",
                Food = "Fish Flakes",
                Swimmer = true
            };
            Copperhead myCopperhead = new Copperhead()
            {
                Species = "Australian Copperhead",
                Name = "Greg",
                Color = "Grey and Brown",
                Food = "Mice",
                Crawler = true,
                Swimmer = true
            };
            Gerbils myGerbil = new Gerbils()
            {
                Species = "Fat-Tailed Gerbil",
                Name = "Tan",
                Color = "Bill",
                Food = "Seeds and Nuts",
                Digger = true,
                Crawler = true
            };
        }
    }
}