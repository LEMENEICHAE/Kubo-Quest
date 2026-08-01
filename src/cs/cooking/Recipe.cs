using System;
using System.Collections.Generic;
using System.Linq;
using Enums;
using Kubos;

namespace Cooking {
    public class Recipe {
        public string Name { get; }
        public List<(Kubo kubo, int weight)> Pool { get; }
        public List<(CResourceType, int amount)> CRscTs { get; }

        public Recipe(string name, List<(Kubo, int)> pool, List<(CResourceType, int)> crscst) {
            Name = name;
            Pool = pool;
            CRscTs = crscst;
        }

        public Kubo RollKubo(Random rng) {
            int totalWeight = Pool.Sum(entry => entry.weight);
            int roll = rng.Next(0, totalWeight);
            int currentSum = 0;

            foreach (var (kubo, weight) in Pool) {
                currentSum += weight;
                if (roll < currentSum) return kubo;
            }

            return Pool.First().kubo;
        }
    }
}