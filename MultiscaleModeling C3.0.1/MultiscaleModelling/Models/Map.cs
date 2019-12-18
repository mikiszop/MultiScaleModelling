using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling.Models
{
    public class Map
    {
        private Pix[,] _nodes;
        private int _width;
        private int _height;
        public Map(int width, int height)
        {
            _nodes = new Pix[width, height];
            _width = width;
            _height = height;
        }

        public Pix GetNode(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < _width  && y < _height)
                return _nodes[x, y];
            return null;
        }
        public void SetNode (Pix node, int x, int y)
        {
            if(x>=0 && y>= 0 && x<_width&&y<_height)
                _nodes[x, y] = node;
        }

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }
    }
}
