using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.Model
{
	public class ContactInfo
	{
		public Address Address { get; set; }
		public Dictionary<string, int> PhoneNumbers { get; set; }
		public Dictionary<string, string> Emails { get; set; }

	}
}
