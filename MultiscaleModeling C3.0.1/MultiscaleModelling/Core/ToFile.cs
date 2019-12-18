﻿using MultiscaleModelling.Controllers;
using MultiscaleModelling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling.Core
{
    class ToFile
    {
        private Simul _simulationEngine;

        public ToFile(Simul simulationEngine)
        {
            _simulationEngine = simulationEngine;
        }


        public void ExportToFile(FileTypeEnum type, string fileName)
        {
            _simulationEngine.MapController.ExportToFile(fileName, type);
        }

        public void ImportFromFile(FileTypeEnum type, string fileName)
        {
            if (_simulationEngine.MapController == null)
                _simulationEngine.MapController = new MapControl();
            _simulationEngine.MapController.ImportFromFile(fileName, type);

            if (_simulationEngine.Configuration == null)
            {
                _simulationEngine.Configuration = new Configuration()
                {
                    BoundaryConditions = BCEnum.NonPeriodical,
                    Neighbourhood = NeighbourhoodEnum.Moore
                };
            }

            _simulationEngine.EndSimulation = true;
            _simulationEngine.IsMapEmpty = false;
            _simulationEngine.Configuration.Width = _simulationEngine.MapController.Width - 2;
            _simulationEngine.Configuration.Height = _simulationEngine.MapController.Height - 2;

            _simulationEngine.GenerateListOfGrains();
            _simulationEngine.Configuration.NumberOfGrains = _simulationEngine.Grains.Count;
        }

    }
}
