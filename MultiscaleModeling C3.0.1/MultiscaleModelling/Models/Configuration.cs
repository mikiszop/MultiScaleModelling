﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling.Models
{
    public class Configuration
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumberOfGrains { get; set; }
        public int SizeOfGB { get; set; }
        public int NumberOfSubGrains { get; set; }
        public BCEnum BoundaryConditions { get; set; }
        public NeighbourhoodEnum Neighbourhood { get; set; }
        public StructureTypeEnume StructureTypeEnume { get; set; }
        public int MooreProbability { get; set; }
        public double J { get; set; }
        public bool IsMC { get; set; }
        public int MCIterations { get; set; }
        public bool IsRecrystallization { get; set; }
        public ConfigurationRecrystallization ConfigurationRecrystallization { get; set; }
        public double BorderEnergy { get; set; }
        public double GrainEnergy { get; set; }
    }
}
