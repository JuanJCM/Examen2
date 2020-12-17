using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarEnergySystem.Core.Services
{
    class ElectricityReadingService : IElectricityReadingRepository
    {
        public ElectricityReading GetReporte()
        {
            throw new NotImplementedException();
            /*services.AddScoped(typeof(IRepository<,>), typeof(EntityFrameworkRepository<,>));*/
        }
    }
}
