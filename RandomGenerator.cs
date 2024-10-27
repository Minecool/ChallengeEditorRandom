using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEditorRandom
{
    public static class RandomGenerator
    {
        public static readonly CEMod maxTowers = new() { max = 10f, min = 2f, chanceToMod = 0.35f };
        public static readonly CEMod towerCount = new() { max = 6f, min = 1f, chanceToMod = 0.4f };
        public static readonly CEMod chanceForTower = new() { chanceToMod = 0.16f };
        public static readonly CEMod chanceForHero = new() { chanceToMod = 0.72f };
        public static readonly CEMod bloonSpeed = new() { max = 2f, min = 0.5f, chanceToMod = 0.4f };
        public static readonly CEMod moabSpeed = new() { max = 2f, min = 0.5f, chanceToMod = 0.4f };
        public static readonly CEMod ceramicHealth = new() { max = 2f, min = 0.5f, chanceToMod = 0.15f };
        public static readonly CEMod moabHealth = new() { max = 2f, min = 0.5f, chanceToMod = 0.35f };
        public static readonly CEMod regrowSpeed = new() { max = 15f, min = 0.05f, chanceToMod = 0.25f };
        public static readonly CEMod abilityCooldownReduction = new() { max = 2f, min = 0.05f, chanceToMod = 0.1f };
        public static readonly CEMod removeableCost = new() { max = 10f, min = 0f, chanceToMod = 0.1f };
        public static readonly CEMod disableMK = new() { chanceToMod = 0.2f };
        public static readonly CEMod disableSelling = new() { chanceToMod = 0.2f };
        public static readonly CEMod disablePowers = new() { chanceToMod = 0f };
        public static readonly CEMod noContinues = new() { chanceToMod = 0f };
        public static readonly CEMod startLives = new() { max = 200f, min = 1f, chanceToMod = 1f };
        public static readonly CEMod maxLives = new() { max = 200f, min = 1f, chanceToMod = 1f };
        public static readonly CEMod startRound = new() { max = 50f, min = 1f, chanceToMod = 1f };
        public static readonly CEMod endRound = new() { max = 50f, min = 10f, chanceToMod = 1f };
        public static readonly CEMod startCash = new() { max = 500f, min = 300f, chanceToMod = 1f };
        public static readonly CEMod noLivesLost = new() { chanceToMod = 0.15f };
        public static readonly CEMod allCamo = new() { chanceToMod = 0.15f };
        public static readonly CEMod allRegen = new() { chanceToMod = 0.15f };
    }
}
