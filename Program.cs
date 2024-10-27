using ChallengeEditorRandom;
using Newtonsoft.Json;

public class Program
{
    static readonly List<string> Towers = ["DartMonkey", "BoomerangMonkey", "BombShooter", "TackShooter", "IceMonkey", "GlueGunner", "SniperMonkey", "MonkeySub", "MonkeyBuccaneer", "MonkeyAce", "HeliPilot", "MortarMonkey", "DartlingGunner", "WizardMonkey", "SuperMonkey", "NinjaMonkey", "Alchemist", "Druid", "Mermonkey", "BananaFarm", "SpikeFactory", "MonkeyVillage", "EngineerMonkey", "BeastHandler"];
    static readonly List<string> Heroes = ["ChosenPrimaryHero", "Quincy", "Gwendolin", "StrikerJones", "ObynGreenfoot", "CaptainChurchill", "Benjamin", "Ezili", "PatFusty", "Adora", "AdmiralBrickell", "Etienne", "Sauda", "Psi", "Geraldo", "Corvus", "Rosalia"];
    static readonly List<string> Maps = ["Tutorial", "InTheLoop", "MiddleOfTheRoad", "Tinkerton", "TreeStump", "TownCentre", "OneTwoTree", "Scrapyard", "TheCabin", "Resort", "Skates", "LotusIsland", "CandyFalls", "WinterPark", "Carved", "ParkPath", "AlpineRun", "FrozenOver", "Cubism", "FourCircles", "Hedge", "EndOfTheRoad", "Logs", "LuminousCove", "SulfurSprings", "WaterPark", "Polyphemus", "CoveredGarden", "Quarry", "QuietStreet", "BloonariusPrime", "Balance", "Encrypted", "Bazaar", "AdorasTemple", "SpringSpring", "KartsNDarts", "MoonLanding", "Haunted", "Downstream", "FiringRange", "Cracked", "Streambed", "Chutes", "Rake", "SpiceIslands", "CastleRevenge", "DarkPath", "Erosion", "MidnightMansion", "SunkenColumns", "XFactor", "Mesa", "Geared", "Spillway", "Cargo", "PatsPond", "Peninsula", "HighFinance", "AnotherBrick", "OffTheCoast", "Cornfield", "Underground", "GlacialTrail", "DarkDungeons", "Sanctuary", "Ravine", "FloodedValley", "Infernal", "BloodyPuddles", "Workshop", "Quad", "DarkCastle", "MuddyPuddles", "#ouch", "Blons"];
    static readonly List<string> Difficulties = ["Easy", "Medium", "Hard"];
    static readonly List<string> GameMode = ["Standard", "Standard", "Deflation", "Standard", "Apopalypse", "Reverse", "Standard", "Half Cash", "Double HP Moabs", "ABR", "Impoppable", "CHIMPS", "Standard"];

    public static DailyChallengeModel GenerateChallenge()
    {
        DailyChallengeModel dcm = new();

        foreach (string tower in Towers)
        {
            TowerData towerData = new();
            if (RandomGenerator.chanceForTower.chanceToMod <= XORShift128.NextFloat()) continue;
            towerData.tower = tower;
            if (RandomGenerator.towerCount.chanceToMod <= XORShift128.NextFloat())
            {
                towerData.max = (int)XORShift128.NextFloatRange(RandomGenerator.towerCount.min, RandomGenerator.towerCount.max);
            }
            dcm.towers.Add(towerData);
        }

        if (XORShift128.NextFloat() < RandomGenerator.chanceForHero.chanceToMod)
        {
            TowerData towerData = new();
            towerData.isHero = true;
            towerData.max = 1;
            towerData.tower = Heroes[XORShift128.NextIntRange(0, Heroes.Count)];
            dcm.towers.Add(towerData);
        }

        dcm.map = Maps[XORShift128.NextIntRange(0, Maps.Count)];
        dcm.difficulty = Difficulties[XORShift128.NextIntRange(0, Difficulties.Count)];
        dcm.mode = GameMode[XORShift128.NextIntRange(0, GameMode.Count)];

        if (XORShift128.NextFloat() < RandomGenerator.maxTowers.chanceToMod)
        {
            dcm.maxTowers = (int)XORShift128.NextFloatRange(RandomGenerator.maxTowers.min, RandomGenerator.maxTowers.max);
        }

        dcm.disableMK = RandomGenerator.disableMK.chanceToMod > XORShift128.NextFloat();
        dcm.disableSelling = RandomGenerator.disableSelling.chanceToMod > XORShift128.NextFloat();
        XORShift128.NextFloat(); // Powers. Chance is 0
        XORShift128.NextFloat(); // Continues. Chance is 0
        dcm.bloonModifiers.allCamo = RandomGenerator.allCamo.chanceToMod > XORShift128.NextFloat();
        dcm.bloonModifiers.allRegen = RandomGenerator.allRegen.chanceToMod > XORShift128.NextFloat();

        if (RandomGenerator.bloonSpeed.chanceToMod > XORShift128.NextFloat())
        {
            dcm.bloonModifiers.speedMultiplier = XORShift128.NextFloatRange(RandomGenerator.bloonSpeed.min, RandomGenerator.bloonSpeed.max);
        }

        if (RandomGenerator.moabSpeed.chanceToMod > XORShift128.NextFloat())
        {
            dcm.bloonModifiers.moabSpeedMultiplier = XORShift128.NextFloatRange(RandomGenerator.moabSpeed.min, RandomGenerator.moabSpeed.max);
        }

        if (RandomGenerator.ceramicHealth.chanceToMod > XORShift128.NextFloat())
        {
            dcm.bloonModifiers.healthMultipliers.bloons = XORShift128.NextFloatRange(RandomGenerator.ceramicHealth.min, RandomGenerator.ceramicHealth.max);
        }

        if (RandomGenerator.moabHealth.chanceToMod > XORShift128.NextFloat())
        {
            dcm.bloonModifiers.healthMultipliers.moabs = XORShift128.NextFloatRange(RandomGenerator.moabHealth.min, RandomGenerator.moabHealth.max);
        }

        if (RandomGenerator.regrowSpeed.chanceToMod > XORShift128.NextFloat())
        {
            dcm.bloonModifiers.regrowRateMultiplier = XORShift128.NextFloatRange(RandomGenerator.regrowSpeed.min, RandomGenerator.regrowSpeed.max);
        }

        if (RandomGenerator.abilityCooldownReduction.chanceToMod > XORShift128.NextFloat())
        {
            dcm.abilityCooldownReductionMultiplier = XORShift128.NextFloatRange(RandomGenerator.abilityCooldownReduction.min, RandomGenerator.abilityCooldownReduction.max);
        }

        if (RandomGenerator.removeableCost.chanceToMod > XORShift128.NextFloat())
        {
            dcm.removeableCostMultiplier = XORShift128.NextFloatRange(RandomGenerator.removeableCost.min, RandomGenerator.removeableCost.max);
        }

        if (RandomGenerator.startLives.chanceToMod > XORShift128.NextFloat())
        {
            dcm.startRules.lives = (int)XORShift128.NextFloatRange(RandomGenerator.startLives.min, RandomGenerator.startLives.max);
        }

        if (RandomGenerator.maxLives.chanceToMod > XORShift128.NextFloat())
        {
            dcm.startRules.maxLives = (int)XORShift128.NextFloatRange(RandomGenerator.maxLives.min, RandomGenerator.maxLives.max);
        }

        if (dcm.startRules.maxLives < dcm.startRules.lives) dcm.startRules.maxLives = dcm.startRules.lives;

        if (RandomGenerator.noLivesLost.chanceToMod > XORShift128.NextFloat())
        {
            dcm.startRules.lives = 1;
            dcm.startRules.maxLives = 1;
        }

        if (RandomGenerator.startRound.chanceToMod > XORShift128.NextFloat())
        {
            dcm.startRules.round = (int)XORShift128.NextFloatRange(RandomGenerator.startRound.min, RandomGenerator.startRound.max);
        }

        if (RandomGenerator.endRound.chanceToMod > XORShift128.NextFloat())
        {
            dcm.startRules.endRound = dcm.startRules.round + 10 + (int)XORShift128.NextFloatRange(RandomGenerator.endRound.min, RandomGenerator.endRound.max);
        }

        if (RandomGenerator.startCash.chanceToMod > XORShift128.NextFloat())
        {
            dcm.startRules.cash = dcm.startRules.round * (int)XORShift128.NextFloatRange(RandomGenerator.startCash.min, RandomGenerator.startCash.max);
        }
        return dcm;
    }
    static void Main()
    {
        XORShift128.InitSeed(437354425);


        Console.WriteLine("Next 10 maps:");
        for (int i=0;i<10;i++)
        {
            Console.WriteLine(GenerateChallenge().map);
        }
    }
}