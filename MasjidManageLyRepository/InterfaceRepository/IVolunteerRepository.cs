using MasjidManageLyModel;
using MasjidManageLyModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasjidManageLyRepository.InterfaceRepository
{
	public interface IVolunteerRepository
	{
		Task<IEnumerable<Volunteer>> GetAllVolunAsync();
		Task<Volunteer> GetByIdAsync(int id);
		Task AddAsync(Volunteer entity);
		Task UpdateAsync(Volunteer entity);
		Task DeleteAsync(int id);
	}
}
