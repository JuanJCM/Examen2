using SolarEnergySystem.Core;
using SolarEnergySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarEnergySystem.Infrastructure.Repositories
{
    public class PanelRepository : EntityFrameworkRepository<Panel, string>, IPanelRepository
    {
        public PanelRepository(SolarEnergySystemDatabaseContext dbContext)
            : base(dbContext)
        {

        }

        public ServiceResult<IEnumerable<Panel>> ListarPanel()
        {
            return _SolarEnergySystemDatabaseContext.Panel.
                .Include(p => p.Id)
                .Include(p => p.MeasuringUnit)
                .Include(p => p.TypePanel)
                .OrderBy(p.TypePanel).ToList();
        }
    }
}
