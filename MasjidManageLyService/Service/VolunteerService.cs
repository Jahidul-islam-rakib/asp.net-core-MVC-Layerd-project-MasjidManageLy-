using MasjidManageLyModel.Entities;
using MasjidManageLyRepository.InterfaceRepository;
using MasjidManageLyService.InterfaceService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasjidManageLyService.Service
{
	public class VolunteerService : IVolunteerService
	{
		private IVolunteerRepository _VolunteerRepository;

		public VolunteerService(IVolunteerRepository VolunteerRepository)
		{
			_VolunteerRepository = VolunteerRepository;
		}

		public async Task<IEnumerable<Volunteer>> GetAllVolunAsync()
		{
			return await _VolunteerRepository.GetAllVolunAsync();
		}


		public async Task<Volunteer> GetByIdAsync(int id)
		{
			return await _VolunteerRepository.GetByIdAsync(id);

		}

		public async Task AddAsync(Volunteer entity)
		{

			await _VolunteerRepository.AddAsync(entity);

		}

		public async Task UpdateAsync(Volunteer entity)
		{
			await _VolunteerRepository.UpdateAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			await _VolunteerRepository.DeleteAsync(id);
		}
	}
}
