using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasjidManageLyModel.Entities
{
	public class Volunteer
	{
		[Key]
		public int Id { get; set; }
		public string VName { get; set; }
		public string VRole { get; set; }
		public string VContactNumber { get; set; }
	}
}
