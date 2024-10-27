using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEditorRandom
{
    public class BloonModifiers
    {
        public float speedMultiplier = 1f;
        public float moabSpeedMultiplier = 1f;
        public float regrowRateMultiplier = 1f;
        public BloonHealthMultipliers healthMultipliers = new()
        {
            bloons = 1f,
            moabs = 1f
        };
        public bool allCamo;
        public bool allRegen;
    }
}
