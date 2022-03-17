using System.Collection.Generic;

namespace CableProvider.Models
{
  public class Package
  {
    public Package()
    {
      this.Channels = new HashSet<Channel>();
      this.JoinEntities = new HashSet<CustomerPackage>();
    }
    public int PackageId { get; set; }
    public int PackagePrice { get; set; }
    public string PackageName { get; set; }

    public virtual ICollection<Channel> Channels { get; set; }
    public virtual ICollection<CustomerPackage> JoinEntities {get;}
  }
}



/*
using System.Collections.Generic;

namespace DoctorsOffice.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
      this.JoinEntities1 = new HashSet<DoctorSpecialty>();
    }

    public int DoctorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
    public virtual ICollection<DoctorSpecialty> JoinEntities1 { get; set; }
  }
}
*/