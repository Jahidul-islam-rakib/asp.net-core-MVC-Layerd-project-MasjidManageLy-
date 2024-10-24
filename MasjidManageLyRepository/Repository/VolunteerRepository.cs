using MasjidManageLyModel.Entities;
using MasjidManageLyRepository.DbConfigure;
using MasjidManageLyRepository.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace MasjidManageLyRepository.Repository
{
	public class VolunteerRepository : IVolunteerRepository
	{
		private readonly MasjidDbContext _context;

		public VolunteerRepository(MasjidDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Volunteer>> GetAllVolunAsync()
		{
			return await _context.Volunteers.ToListAsync();
		}

		public async Task<Volunteer> GetByIdAsync(int id)
		{
			return await _context.Volunteers.FindAsync(id);
		}

		public async Task AddAsync(Volunteer entity)
		{
			_context.Volunteers.Add(entity);
			await _context.SaveChangesAsync();

		}

		public async Task UpdateAsync(Volunteer entity)
		{
			_context.Volunteers.Update(entity);
			await _context.SaveChangesAsync();
		}


		public async Task DeleteAsync(int id)
		{
			var entity = await _context.Volunteers.FindAsync(id);

			if (entity != null)
			{
				_context.Volunteers.Remove(entity);
				await _context.SaveChangesAsync();
			}


		}
	}
}
