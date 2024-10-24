using MasjidManageLyModel;
using Microsoft.EntityFrameworkCore;
using MasjidManageLyModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasjidManageLyRepository.DbConfigure
{
	public class MasjidDbContext : DbContext
	{
        public MasjidDbContext(DbContextOptions<MasjidDbContext> Options) :base(Options)
        {
            
        }

        public DbSet<Volunteer> Volunteers { get; set; }

    }
}
