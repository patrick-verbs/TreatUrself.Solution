using System.Collections.Generic;

namespace TreatUrself.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string SomeProperty { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}