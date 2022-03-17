using System.Collections.Generic;

namespace CableProvider.Models
{
  public class Show
  {
    public Show()
    {
      this.JoinEntities = new HashSet<ChannelShow>();
    }
    public int ShowId{get;set;}
    public string Title{get;set;}
    public string Genre {get;set;}
    public int Duration{get;set;}

    public virtual ICollection<ChannelShow> JoinEntities {get;}
  }
}



