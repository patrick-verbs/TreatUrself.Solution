using System.Collections.Generic;

namespace TreatUrself.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinFlavors = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinFlavors { get; }
  }
}