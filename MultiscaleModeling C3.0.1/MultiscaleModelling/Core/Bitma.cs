using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling.Core
{
    class Bitma
    {

        private Simul _simulationEngine;

        public Bitma( Simul simulationEngine)
        {
            _simulationEngine = simulationEngine;
        }


        public Bitmap GetBitmap()
        {
            return _simulationEngine.MapController.GetBitmap();
        }

        public Bitmap GetBitmapGrainsSelection(bool visibility)
        {

            
                var colorList = new List<int>();
                foreach (var grain in _simulationEngine.SelectedGrains)
                {
                    colorList.Add(grain.Id);
                }

                return _simulationEngine.MapController.GetBitmapWithHiddenColors(colorList);
            
        }
        public Bitmap GetEnergyBitmap()
        {
            return _simulationEngine.MapController.GetBitmapWithEnergyColors();
        }
    }
}
