using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEditorRandom
{
    public class DailyChallengeModel
    {
        public List<TowerData> towers = new();
        public string map = "";
        public string difficulty = "";
        public string mode = "";
        public int maxTowers = -1;
        public BloonModifiers bloonModifiers = new();
        public float removeableCostMultiplier = 1f;
        public float abilityCooldownReductionMultiplier = 1f;
        public bool disableMK;
        public bool disableSelling;
        public StartRules startRules = new();
    }
}
