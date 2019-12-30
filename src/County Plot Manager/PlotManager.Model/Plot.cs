using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.Model
{
	public class Plot
	{
		public string ID { get; set; }
		public Owner Owner { get; set; }
		public List<Tenant> Tenants { get; set; }

	}
}
