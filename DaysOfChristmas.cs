public class DaysOfChristmas
{
  public List<Gift> PresentsFromTrueLoveByDay(byte dayOfChristmas)
  {
    var gifts = new List<Gift>();
      
    if (dayOfChristmas > 12)
    {
      throw new GreedyException();
    }
    
    if (dayOfChristmas == 12)
    {
        var drummers = new Drummers { Quantity = 12, Drumming = true };
        gifts.Add(drummers);
    }
    
    if (dayOfChristmas >= 11)
    {
      var pipers = new Pipers { Quantity = 11, Piping = true };
      gifts.Add(pipers);
    }
    
    if (dayOfChristmas >= 10)
    {
      var lords = new Lords { Quantity = 10, Leaping = false, ALeaping = true };
      gifts.Add(lords);
    }
    
    if (dayOfChristmas >= 9)
    {
      var ladies = new Ladies { Quantity = 9, Status = Action.Dancing };
      gifts.Add(ladies);
    }
    
    if (dayOfChristmas >= 8)
    {
      var maids = new Maids { Quantity = 8, Milking = false, AMilking = true };
      gifts.Add(maids);
    }
    
    if (dayOfChristmas >= 7)
    {
      var swans = new Swans { Quantity = 7, Swimming = false, ASwimming = true };
      gifts.Add(swans);
    }
    
    if (dayOfChristmas >= 6)
    {
      var geese = new Geese { Quantity = 6, Laying = false, ALaying = true };
      gifts.Add(geese);
    }
    
    if (dayOfChristmas >= 5)
    {
      var rings = new Rings { Quantity = 5, Type = Metal.GoOld };
      gifts.Add(rings);
    }
    
    if (dayOfChristmas >= 4)
    {
      var birds = new Birds { Quantity = 4, Calling = true };
      gifts.Add(birds);
    }
    
    if (dayOfChristmas >= 3)
    {
      var hens = new Hens { Quantity = 3, CountryOfOrigin = "fr-FR" };
      gifts.Add(hens);
    }
    
    if (dayOfChristmas >= 2)
    {
      var doves = new Doves { Quantity = 2, Type = DoveType.Turtle };
      gifts.Add(doves);
    }
    
    if (dayOfChristmas >= 1)
    {
      var partridge = new Partridge { Quantity = 1, Location = Trees.Pair };
      gifts.Add(partridge);
    }
      
    return gifts;
  }
}
