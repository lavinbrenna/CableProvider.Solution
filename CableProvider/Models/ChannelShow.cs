namespace CableProvider.Models
{
  public class ChannelShow
  {
    public int ChannelShowId { get; set; }
    public int ShowId { get; set; }
    public int ChannelId { get; set; }

    public virtual Channel Channel { get; set; }
    public virtual Show Show { get; set; }
  }
}