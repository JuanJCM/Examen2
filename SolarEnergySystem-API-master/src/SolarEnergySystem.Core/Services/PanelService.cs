using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarEnergySystem.Core.Services
{
    class PanelService : IPanelRepository
    {
        public ServiceResult<IEnumerable<Panel>> ListarPanel()
        {
            throw new NotImplementedException();
        }
    }
}
