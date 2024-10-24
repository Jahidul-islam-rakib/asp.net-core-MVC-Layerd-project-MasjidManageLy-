using MasjidManageLyModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasjidManageLyService.InterfaceService
{
	public interface IVolunteerService
	{
		Task<IEnumerable<Volunteer>> GetAllVolunAsync();
		Task<Volunteer> GetByIdAsync(int id);
		Task AddAsync(Volunteer entity);
		Task UpdateAsync(Volunteer entity);
		Task DeleteAsync(int id);
	}
}
