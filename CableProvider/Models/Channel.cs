using System.Collections.Generic;

namespace CableProvider.Models
{
  public class Channel
  {
    public Channel()
    {
      this.JoinEntities = new HashSet<ChannelShow>();
    }
    public int ChannelId {get;set;}
    public string Name {get;set;}

    public virtual ICollection<ChannelShow> JoinEntities {get;set;}

  }
}