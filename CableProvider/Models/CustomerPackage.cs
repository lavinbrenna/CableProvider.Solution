namespace CableProvider.Models
{
  public class CustomerPackage
  {
    public int CustomerPackageId {get;set;}
    public int PackageId {get;set;}
    public int CustomerId{get;set;}
    public virtual Package package{get;set;}
    public virtual Customer customer {get;set;}
  }
}