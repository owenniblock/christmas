public class ComingToTown
{
  var list = Santa.MakeList();

  var check1 = Santa.CheckList(list);
  var check2 = Santa.CheckList(list);

  foreach (var child in list)
  {
    if (check1[child].Status == Status.Nice || check2[child].Status == Status.Nice)
    {
      Santa.GivePresents(child);
    }
  }

  Santa.ComeToTown();
}
