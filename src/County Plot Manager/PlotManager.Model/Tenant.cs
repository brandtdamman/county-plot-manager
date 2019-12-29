using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotManager.Model
{

	public enum Gender
	{
		Female,
		Male
	}

	public class Tenant
	{
		public int ID { get; set; }
		public Name Name { get; set; }
		public Gender Gender { get; set; }
		public DateTime? DateInterred { get; set; }
		public DateTime? DateOfBirth { get; set; }
		public DateTime? DateOfDeath { get; set; }
		public List<Tenant> Relatives { get; set; }

	}
}
