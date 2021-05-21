using System.Collections.Generic;
using System;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public DateTime HireDate { get; set; }
    public DateTime BirthDay { get; set; }
    public string Notes { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}