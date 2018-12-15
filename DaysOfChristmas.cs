public class DaysOfChristmas
{
  public List<Gift> PresentsFromTrueLoveByDay(byte dayOfChristmas)
  {
    switch (caseSwitch)
    {
      var gifts = new List<Gift>();
      
      case 12:
        var drummers = new Drummers { Quantity = 12, Drumming = true };
        gifts.Add(drummers);
      case 11:
        var pipers = new Pipers { Quantity = 11, Piping = true };
        gifts.Add(pipers);
      case 10:
        var lords = new Lords { Quantity = 10, Leaping = false, ALeaping = true };
        gifts.Add(lords);
      case 9:
        var ladies = new Ladies { Quantity = 9, Status = Action.Dancing };
        gifts.Add(ladies);
      case 8:
        var maids = new Maids { Quantity = 8, Milking = false, AMilking = true };
        gifts.Add(maids);
      case 7:
        var swans = new Swans { Quantity = 7, Swimming = false, ASwimming = true };
        gifts.Add(swans);
      case 6:
        var geese = new Geese { Quantity = 6, Laying = false, ALaying = true };
        gifts.Add(geese);
      case 5:
        var rings = new Rings { Quantity = 5, Type = Metal.GoOld };
        gifts.Add(rings);
      case 4:
        var birds = new Birds { Quantity = 4, Calling = true };
        gifts.Add(birds);
      case 3:
        var hens = new Hens { Quantity = 3, CountryOfOrigin = "fr-FR" };
        gifts.Add(hens);
      case 2:
        var doves = new Doves { Quantity = 2, Type = DoveType.Turtle };
        gifts.Add(doves);
      default:
        var partridge = new Partridge { Quantity = 1, Location = Trees.Pair };
        gifts.Add(partridge);
        break;
      }
      
      return gifts;
  }
}
