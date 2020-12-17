using SolarEnergySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarEnergySystem.Infrastructure.Repositories
{
    public class ElectricityReadingRepository : EntityFrameworkRepository<ElectricityReading>, IElectricityReadingRepository
    {
        public ElectricityReading GetReporte()
        {
            return _solarEnergySystemDatabaseContext.ElectricityReading
                .Include(p => p.Kilowatt)
        }
    }
}
