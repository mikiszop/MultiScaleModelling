using MultiscaleModelling.Controllers;
using MultiscaleModelling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiscaleModelling.Interfaces;

namespace MultiscaleModelling.Core
{
    class CA : IProcessable
    {

        private Simul _simulationEngine;
        private Random _random;

        public CA(Random random, Simul simulationEngine)
        {
            _random = random;
            _simulationEngine = simulationEngine;
        }

        public void InitializeStep()
        {
            //seed grains
            int grainsToGenerate = _simulationEngine.Configuration.NumberOfGrains;
            while (grainsToGenerate > 0)
            {
                var grain = _simulationEngine.GetRandomGrain();
                _simulationEngine.Grains.Add(grain);
                AddGrainToRandomPosition(grain);

                _simulationEngine.MapController.Commit();
                _simulationEngine.MapController.CopyMap();
                grainsToGenerate--;
            }

            _simulationEngine.GenerateListOfGrains();
        }
        public void NextStep()
        {


            _simulationEngine.EndSimulation = true;
            int size = _simulationEngine.Configuration.Width * _simulationEngine.Configuration.Height;
            for (int x = 1; x <= _simulationEngine.Configuration.Width; x++)
            {
                for (int y = 1; y <= _simulationEngine.Configuration.Height; y++)
                {
                    ProcessCoordinate(x, y);
                }
            }
            _simulationEngine.MapController.Commit();
            //if (iter >= size)
            //{
            //    _simulationEngine.EndSimulation = true;
            //}
            

            if (_simulationEngine.EndSimulation)
            {
                //iter = 0;
                _simulationEngine.EndSubstructureSimulation();
            }
        }

        private void AddGrainToRandomPosition(Grain grain)
        {
            int x, y;
            bool correctCoordinate = false;
            do
            {
                x = _random.Next(1, _simulationEngine.Configuration.Width);
                y = _random.Next(1, _simulationEngine.Configuration.Height);

                correctCoordinate = _simulationEngine.MapController.GetNode(x, y).Type == TypeEnum.Empty;
            } while (!correctCoordinate);

            var node = new Pix()
            {
                X = x,
                Y = y,
                Color = grain.Color,
                Id = grain.Id,
                Type = TypeEnum.Grain
            };

            _simulationEngine.MapController.SetNode(x, y, node);
        }
        private void ProcessCoordinate(int x, int y)
        {
            var node = _simulationEngine.MapController.GetNode(x, y);

            if (node.Type == TypeEnum.Empty)
            {
                _simulationEngine.EndSimulation = false;

                node = GetNodeForCA(node, _simulationEngine.Configuration.Neighbourhood);
            }


            _simulationEngine.MapController.SetNode(x, y, new Pix()
            {
                X = x,
                Y = y,
                Id = node.Id,
                Color = node.Color,
                Type = node.Type
            });
        }
        private Pix GetNodeForCA(Pix node, NeighbourhoodEnum type)
        {
            switch (type)
            {
                case NeighbourhoodEnum.Moore:
                case NeighbourhoodEnum.VonNeumann:
                    return GetNodeforStandardMethod(node);
                case NeighbourhoodEnum.Moore2:
                    return GetNodeforModificationMethod(node);
            }
            return null;
        }
        //node chosing algorithm vonneuman moore
        private Pix GetNodeforStandardMethod(Pix node)
        {
            var neighbourhood = _simulationEngine.MapController.GetNeighbourhoods(node.X, node.Y, _simulationEngine.Configuration.Neighbourhood);
            if (neighbourhood != null)
            {
                neighbourhood = neighbourhood.Where(k => k.Type != null && k.Type == TypeEnum.Grain).ToList();
            }
                if (neighbourhood.Any())
            {
                var orderedNeighbourhood = neighbourhood.GroupBy(s => s).Select(g => new KeyValuePair<Pix, int>(g.First(), g.Count())).OrderByDescending(p => p.Value).ToList();
                var winnerValue = orderedNeighbourhood.FirstOrDefault().Value;

                var winners = orderedNeighbourhood.Where(p => p.Value == winnerValue).ToList();
                var randomWinner = winners[_random.Next(winners.Count)].Key;

                node = randomWinner;
            }

            return node;
        }
        private Pix GetNodeforModificationMethod(Pix node)
        {
            var mooreNeighbourhood = GetListOfGrainNeighbourhood(node, NeighbourhoodEnum.Moore);
            if (mooreNeighbourhood == null || !mooreNeighbourhood.Any())
                return node;
            if (mooreNeighbourhood.FirstOrDefault().Value >= 5)
            {
                return mooreNeighbourhood.FirstOrDefault().Key;
            }

            var secondNeighbourhood = GetListOfGrainNeighbourhood(node, NeighbourhoodEnum.VonNeumann);
            if (secondNeighbourhood != null && secondNeighbourhood.FirstOrDefault().Value >= 3)
            {
                return secondNeighbourhood.FirstOrDefault().Key;
            }

            var trNeighbourhood = GetListOfGrainNeighbourhood(node, NeighbourhoodEnum.Cross);
            if (trNeighbourhood != null && trNeighbourhood.FirstOrDefault().Value >= 3)
            {
                return trNeighbourhood.FirstOrDefault().Key;
            }

            int randomNumber = _random.Next(100);
            if (randomNumber < _simulationEngine.Configuration.MooreProbability)
            {
                var winnerValue = mooreNeighbourhood.FirstOrDefault().Value;
                var winners = mooreNeighbourhood.Where(p => p.Value == winnerValue).ToList();
                return winners[_random.Next(winners.Count)].Key;
            }

            return node;
        }
        private List<KeyValuePair<Pix, int>> GetListOfGrainNeighbourhood(Pix node, NeighbourhoodEnum type)
        {
            var neighbourhood = _simulationEngine.MapController.GetNeighbourhoods(node.X, node.Y, type);

            neighbourhood = neighbourhood.Where(k => k.Type == TypeEnum.Grain).ToList();

            if (neighbourhood.Any())
            {
                var orderedNeighbourhood = neighbourhood.GroupBy(s => s).Select(g => new KeyValuePair<Pix, int>(g.First(), g.Count())).OrderByDescending(p => p.Value).ToList();
                return orderedNeighbourhood;
            }
            return null;
        }

    }
}
