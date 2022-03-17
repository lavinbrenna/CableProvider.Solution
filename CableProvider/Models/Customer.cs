using System.Collection.Generic;
using System;

namespace CableProvider.Models
{
  public class Customer
  {
    public Customer()
    {
      this.JoinEntities = new HashSet<CustomerPackage>();
    }
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public int BillTotal { get; set; }
    public DateTime StartDate { get; set; }
    public virtual ICollection<CustomerPackage> JoinEntities {get;set;}
   
  }
}