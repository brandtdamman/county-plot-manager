using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.Model
{
    public class PhoneNumber
    {
    public int IsPrimary { get; set; }
    public string Number { get; set; }
    public string Description { get; set; }

    public PhoneNumber(int primary = 0, string number = "515.555.5555", string description = "mobile")
    {
      IsPrimary = primary;
      Number = number;
      Description = description;
    }
  }
}
