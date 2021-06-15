using System.Collections.Generic;

namespace TreatUrself.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinTreats = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinTreats { get; set; }
  }
}