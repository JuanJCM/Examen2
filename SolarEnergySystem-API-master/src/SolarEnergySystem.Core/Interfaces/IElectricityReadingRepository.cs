using SolarEnergySystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarEnergySystem.Core.Interfaces
{
    interface IElectricityReadingRepository
    {
        ElectricityReading GetReporte();
    }
}
