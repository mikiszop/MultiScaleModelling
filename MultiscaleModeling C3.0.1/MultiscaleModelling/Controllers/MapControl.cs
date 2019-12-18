using MultiscaleModelling.Helpers;
using MultiscaleModelling.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling.Controllers
{
    public class MapControl 
    {
        private static Color _borderColor = Color.Black;
        private static Color _emptyColor = Color.White;
        private static Color _inclusionColor = Color.Black;
        private static Color _borderGraintColor = Color.Black;
        private static Color _recrystalizationColor = Color.Red;


        private int _width;
        private int _height; 
        private Map _previousMap;
        private Map _currentMap;


        public MapControl()
        {

        }
        public MapControl(int width, int height)
        {
            //add borders
            width+=2;
            height+=2;

             _width = width;
            _height = height;
            _currentMap = new Map(_width, _height);
            Commit();
        }

        public void Commit()
        {
            _previousMap = _currentMap;
            CreteNewMap();
        }

        public void CopyMap()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    _currentMap.SetNode(_previousMap.GetNode(x, y),x,y);
                }
            }
        }

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public Pix GetNode (int x, int y)
        {
            return _previousMap.GetNode(x, y);
        }
        public List<Pix> GetNeighbourhoods(int x, int y, NeighbourhoodEnum type, bool isFromCurrent = false)
        {
            switch (type)
            {
                case NeighbourhoodEnum.Moore:
                    return GetMooreNeighbourhoods(x, y, isFromCurrent);
                case NeighbourhoodEnum.VonNeumann:
                    return GetVonNeumannNeighbourhoods(x,y, isFromCurrent);
                case NeighbourhoodEnum.Cross:
                    return GetCrossNeighbourhoods(x, y, isFromCurrent);
            }
            return new List<Pix>();
        }

        public void SetNode(int x, int y, Pix node)
        {
            if(x >= 0 && y >= 0 && x < _width && y < _height)
                _currentMap.SetNode(node, x, y);
        }
        public Pix GetCurrentNode(int x, int y)
        {
            if (x < _width && y < _height)
                return _currentMap.GetNode(x, y);
            return null;
        }
        public Bitmap GetBitmapWithEnergyColors()
        {
            var energyColors = GetEnergyColors(Color.YellowGreen, Color.DarkBlue, 101);
            Bitmap bitmap = new Bitmap(_width, _height);
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var node = _previousMap.GetNode(x, y);
                    var energy = node.H / 7.0 * 100;

                    if (node.Type == TypeEnum.Border)
                        bitmap.SetPixel(x, y, _previousMap.GetNode(x, y).Color);
                    else if (node.Type == TypeEnum.Recrystallization)
                        bitmap.SetPixel(x, y, _recrystalizationColor);
                    else
                        bitmap.SetPixel(x, y, energyColors[(int)energy]);
                }
            }
            return bitmap;
        }
        private List<Color> GetEnergyColors(Color fColor, Color sColor, int size)
        {

            int rMax = fColor.R;
            int rMin = sColor.R;
            int gMax = fColor.G;
            int gMin = sColor.G;
            int bMax = fColor.B;
            int bMin = sColor.B;

            var colorList = new List<Color>();
            for (int i = 0; i < size; i++)
            {
                var rAverage = rMin + (int)((rMax - rMin) * i / size);
                var gAverage = gMin + (int)((gMax - gMin) * i / size);
                var bAverage = bMin + (int)((bMax - bMin) * i / size);
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }
            return colorList;
        }

        public Bitmap GetBitmap()
        {
            Bitmap bitmap = new Bitmap(_width, _height);
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var node = _previousMap.GetNode(x, y);
                    bitmap.SetPixel(x, y, node.Color);
                }
            }
            return bitmap;
        }
        public Bitmap GetBitmapWithHiddenColors(List<int> ids)
        {
            Bitmap bitmap = new Bitmap(_width, _height);
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    var node = _previousMap.GetNode(x, y);
               
                    if(!ids.Contains(node.Id))
                        bitmap.SetPixel(x, y, _previousMap.GetNode(x, y).Color);
                    else
                        bitmap.SetPixel(x, y, _emptyColor);
                }
            }
            return bitmap;
        }

        //private List<Color> GetEnergyColors(Color fColor, Color sColor,int size)
        //{

        //    int rMax = fColor.R;
        //    int rMin = sColor.R;
        //    int gMax = fColor.G;
        //    int gMin = sColor.G;
        //    int bMax = fColor.B;
        //    int bMin = sColor.B;

        //    var colorList = new List<Color>();
        //    for (int i = 0; i < size; i++)
        //    {
        //        var rAverage = rMin + (int)((rMax - rMin) * i / size);
        //        var gAverage = gMin + (int)((gMax - gMin) * i / size);
        //        var bAverage = bMin + (int)((bMax - bMin) * i / size);
        //        colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
        //    }
        //    return colorList;
        //}
        //public Bitmap GetBitmapWithEnergyColors()
        //{
        //    var energyColors = GetEnergyColors(Color.Yellow, Color.Blue,101);
        //    Bitmap bitmap = new Bitmap(_width, _height);
        //    for (int x = 0; x < _width; x++)
        //    {
        //        for (int y = 0; y < _height; y++)
        //        {
        //            var node = _previousMap.GetNode(x, y);
        //            var energy = node.H / 7.0 * 100;
                    
        //            if(node.Type == TypeEnum.Border)
        //                bitmap.SetPixel(x, y, _previousMap.GetNode(x, y).Color);
        //            else if (node.Type == TypeEnum.Recrystallization)
        //                bitmap.SetPixel(x, y, _recrystalizationColor);
        //            else
        //                bitmap.SetPixel(x, y, energyColors[(int)energy]);
        //        }
        //    }
        //    return bitmap;
        //}
        public void ImportFromFile(string name,FileTypeEnum type)
        {
            var mapper = GetColorMapper();
            switch (type)
            {
                case FileTypeEnum.Bmp:
                    _currentMap = FileHelper.ImportFromBmp(name, mapper);
                    break;
                case FileTypeEnum.Text:
                    _currentMap = FileHelper.ImportFromTxt(name, mapper);
                    break;
            }

            _width = _currentMap.Width;
            _height = _currentMap.Height;

            Commit();
        }
        public void ExportToFile(string name, FileTypeEnum type)
        {
            switch (type)
            {
                case FileTypeEnum.Bmp:
                    FileHelper.ExportToBmp(GetBitmap(),name);
                    break;
                case FileTypeEnum.Text:
                    FileHelper.ExportToTxt(_previousMap, name);
                    break;
            }
        }

        public Pix GetEmptyNode(int x, int y)
        {
            return new Pix()
            {
                Color = _emptyColor,
                Id = 0,
                Type = TypeEnum.Empty,
                X=x,
                Y=y
            };
        }
        public Pix GetInclusionNode(int x, int y)
        {
            return new Pix()
            {
                Color = _inclusionColor,
                Id = 3,
                Type = TypeEnum.Inclusion,
                X = x,
                Y = y
            };
        }

        public Color GetGrainBorderColor()
        {
            return _borderGraintColor;
        }

        private Dictionary<TypeEnum,Color> GetColorMapper()
        {
            var result = new Dictionary<TypeEnum,Color>();

            result.Add(TypeEnum.Border,_borderColor );
            //result.Add(TypeEnum.Inclusion,_inclusionColor);
            result.Add(TypeEnum.Empty,_emptyColor);

            return result;
        }
        private void CreteNewMap()
        {
            _currentMap = new Map(_width, _height);
            CreateEmptyMap();
        }
        private void CreateEmptyMap()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    TypeEnum type = TypeEnum.Empty;
                    Color color = _emptyColor;
                    if (x == 0 || y == 0 || x == _width - 1 || y == _height - 1)
                    {
                        type = TypeEnum.Border;
                        color = _borderColor;
                    }
                    _currentMap.SetNode(new Pix()
                    {
                        X = x,
                        Y = y,
                        Type = type,
                        Color= color
                    }, x, y);
                }
            }
        }

        private List<Pix> GetMooreNeighbourhoods(int x, int y, bool isFromCurrent)
        {
            Map map = _previousMap;
            if (isFromCurrent)
                map = _currentMap;

            List<Pix> neighbourhoods = new List<Pix>();
            for (int k = -1; k <= 1; k++)
            {
                neighbourhoods.Add(map.GetNode(x + k, y + 1));
                neighbourhoods.Add(map.GetNode(x + k, y - 1));
                if (k != 0)
                {
                    neighbourhoods.Add(map.GetNode(x + k, y));
                }
            }

            return neighbourhoods;
        }

        private List<Pix> GetVonNeumannNeighbourhoods(int x, int y, bool isFromCurrent)
        {
            Map map = _previousMap;
            if (isFromCurrent)
                map = _currentMap;

            List<Pix> neighbourhoods = new List<Pix>();

            neighbourhoods.Add(map.GetNode(x , y+1));
            neighbourhoods.Add(map.GetNode(x-1, y));
            neighbourhoods.Add(map.GetNode(x+1, y));
            neighbourhoods.Add(map.GetNode(x, y-1));

            return neighbourhoods;
        }
        private List<Pix> GetCrossNeighbourhoods(int x, int y, bool isFromCurrent)
        {
            Map map = _previousMap;
            if (isFromCurrent)
                map = _currentMap;

            List<Pix> neighbourhoods = new List<Pix>();

            neighbourhoods.Add(map.GetNode(x - 1, y + 1));
            neighbourhoods.Add(map.GetNode(x + 1, y + 1));
            neighbourhoods.Add(map.GetNode(x - 1, y - 1));
            neighbourhoods.Add(map.GetNode(x + 1, y - 1));

            return neighbourhoods;
        }
    }
}
