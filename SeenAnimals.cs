using System;
namespace Safari
{

  public class SeenAnimals
  {
    public int Id { get; set; }
    public string Species { get; set; }
    public int CountOfTimesSeen { get; set; }
    public string LocationOfLastSeen { get; set; }
    public DateTime TimeLastSeen { get; set; }
  }
}