using MultiscaleModelling.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MultiscaleModelling.Controllers;
using MultiscaleModelling.Models;
using MultiscaleModelling.Core;

namespace MultiscaleModelling.Simulation
{
   class StandardSimulation : ISimulation
   {
      private Random _random;


      Core.Bitma _bitmapEngine;
      Simul _simulationEngine;
      InclusionsEngine _inclusionsEngine;
      CA _CAEngine;
      MC _MCEngine;
      ToFile _fileEngine;
      Recrystal _recrystallizationEngine;

        IProcessable _processEngine;

      public StandardSimulation()
      {
         _random = new Random();
         _simulationEngine = new Simul(_random);
         _inclusionsEngine = new InclusionsEngine(_random, _simulationEngine);
          _bitmapEngine = new Core.Bitma(_simulationEngine);
         _CAEngine = new CA(_random, _simulationEngine);
         _MCEngine = new MC(_random, _simulationEngine);
         _fileEngine = new ToFile(_simulationEngine);
         _recrystallizationEngine = new Recrystal(_random, _simulationEngine);

        }


        public Bitmap GetBitmap()
      {
         return _bitmapEngine.GetBitmap();
      }

      public void Initialize(Configuration config)
      {
         _simulationEngine.Initialize(config);
         SetProcessEngine();
      }

      public void Restart()
      {
         _simulationEngine.Restart();
      }

      public void InitializeStep()
      {
         _processEngine.InitializeStep();
      }

      public bool IsMapEmpty()
      {
         return _simulationEngine.IsMapEmpty;
      }

      public void AddInclusions(ConfigurationInclusions config)
      {
         _inclusionsEngine.AddInclusions(config);
      }

        public void NextStep()
      {
         _processEngine.NextStep();
      }

      public void ExportToFile(FileTypeEnum type, string fileName)
      {
         _fileEngine.ExportToFile(type, fileName);
      }

      public void ImportFromFile(FileTypeEnum type, string fileName)
      {
         _fileEngine.ImportFromFile(type, fileName);
      }

      public bool IsEndSimulation()
      {
         return _simulationEngine.EndSimulation;
      }

      public void AddOrRemoveGrainsToSelectLis(int x, int y)
      {
         _simulationEngine.AddOrRemoveGrainsInSelectList(x, y);
      }

        public void StartGenerateSubstructure(Configuration config)
        {
            _simulationEngine.StartGenerateSubstructure(config);
            SetProcessEngine();
        }

        public Configuration GetConfiguration()
      {
         return _simulationEngine.Configuration;
      }  
      
      public void RestartSelectedList()
      {
         _simulationEngine.RestartSelectedList();
      }

      public Bitmap GetBitmapGrainsSelection(bool visibility)
      {
         return _bitmapEngine.GetBitmapGrainsSelection(visibility);
      }


        public void AddBoundariesForGrains(Configuration config)
      {
         _simulationEngine.AddBoundariesForGrains(config);
      }

      public void RemoveGrainsColors()
      {
         _simulationEngine.RemoveGrainsColors();
      }

        public float GetGBPercent()
        {
            return _simulationEngine.GetGBPercent();
        }
        public void CalculateEnergy()
        {
            _simulationEngine.CalculateEnergy();
        }

        public Bitmap GetEnergyBitmap()
        {
            return _bitmapEngine.GetEnergyBitmap();
        }


        private void SetProcessEngine()
      {

            if (_simulationEngine.Configuration.IsRecrystallization)
                _processEngine = _recrystallizationEngine;
            else if (_simulationEngine.Configuration.IsMC)
                _processEngine = _MCEngine;
            else
                _processEngine = _CAEngine;
        }


   }
}
