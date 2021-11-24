﻿/**
 *   Copyright (C) 2021 okaygo
 *
 *   https://github.com/misterokaygo/MapAssist/
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <https://www.gnu.org/licenses/>.
 **/

using System.Collections.Generic;

namespace MapAssist.Types
{
    public enum Area : uint
    {
        Abaddon = 125,
        AncientTunnels = 65,
        ArcaneSanctuary = 74,
        ArreatPlateau = 112,
        ArreatSummit = 120,
        Barracks = 28,
        BlackMarsh = 6,
        BloodMoor = 2,
        BloodyFoothills = 110,
        BurialGrounds = 17,
        CanyonOfTheMagi = 46,
        CatacombsLevel1 = 34,
        CatacombsLevel2 = 35,
        CatacombsLevel3 = 36,
        CatacombsLevel4 = 37,
        Cathedral = 33,
        CaveLevel1 = 9,
        CaveLevel2 = 13,
        ChaosSanctuary = 108,
        CityOfTheDamned = 106,
        ClawViperTempleLevel1 = 58,
        ClawViperTempleLevel2 = 61,
        ColdPlains = 3,
        Crypt = 18,
        CrystallinePassage = 113,
        DarkWood = 5,
        DenOfEvil = 8,
        DisusedFane = 95,
        DisusedReliquary = 99,
        DrifterCavern = 116,
        DryHills = 42,
        DuranceOfHateLevel1 = 100,
        DuranceOfHateLevel2 = 101,
        DuranceOfHateLevel3 = 102,
        DurielsLair = 73,
        FarOasis = 43,
        FlayerDungeonLevel1 = 88,
        FlayerDungeonLevel2 = 89,
        FlayerDungeonLevel3 = 91,
        FlayerJungle = 78,
        ForgottenReliquary = 96,
        ForgottenSands = 134,
        ForgottenTemple = 97,
        ForgottenTower = 20,
        FrigidHighlands = 111,
        FrozenRiver = 114,
        FrozenTundra = 117,
        FurnaceOfPain = 135,
        GlacialTrail = 115,
        GreatMarsh = 77,
        HallsOfAnguish = 122,
        HallsOfPain = 123,
        HallsOfTheDeadLevel1 = 56,
        HallsOfTheDeadLevel2 = 57,
        HallsOfTheDeadLevel3 = 60,
        HallsOfVaught = 124,
        HaremLevel1 = 50,
        HaremLevel2 = 51,
        Harrogath = 109,
        HoleLevel1 = 11,
        HoleLevel2 = 15,
        IcyCellar = 119,
        InfernalPit = 127,
        InnerCloister = 32,
        JailLevel1 = 29,
        JailLevel2 = 30,
        JailLevel3 = 31,
        KurastBazaar = 80,
        KurastCauseway = 82,
        KurastDocks = 75,
        LostCity = 44,
        LowerKurast = 79,
        LutGholein = 40,
        MaggotLairLevel1 = 62,
        MaggotLairLevel2 = 63,
        MaggotLairLevel3 = 64,
        MatronsDen = 133,
        Mausoleum = 19,
        MonasteryGate = 26,
        MooMooFarm = 39,
        NihlathaksTemple = 121,
        None = 0,
        OuterCloister = 27,
        OuterSteppes = 104,
        PalaceCellarLevel1 = 52,
        PalaceCellarLevel2 = 53,
        PalaceCellarLevel3 = 54,
        PitLevel1 = 12,
        PitLevel2 = 16,
        PitOfAcheron = 126,
        PlainsOfDespair = 105,
        RiverOfFlame = 107,
        RockyWaste = 41,
        RogueEncampment = 1,
        RuinedFane = 98,
        RuinedTemple = 94,
        SewersLevel1Act2 = 47,
        SewersLevel1Act3 = 92,
        SewersLevel2Act2 = 48,
        SewersLevel2Act3 = 93,
        SewersLevel3Act2 = 49,
        SpiderCave = 84,
        SpiderCavern = 85,
        SpiderForest = 76,
        StonyField = 4,
        StonyTombLevel1 = 55,
        StonyTombLevel2 = 59,
        SwampyPitLevel1 = 86,
        SwampyPitLevel2 = 87,
        SwampyPitLevel3 = 90,
        TalRashasTomb1 = 66,
        TalRashasTomb2 = 67,
        TalRashasTomb3 = 68,
        TalRashasTomb4 = 69,
        TalRashasTomb5 = 70,
        TalRashasTomb6 = 71,
        TalRashasTomb7 = 72,
        TamoeHighland = 7,
        TheAncientsWay = 118,
        ThePandemoniumFortress = 103,
        TheWorldstoneChamber = 132,
        TheWorldStoneKeepLevel1 = 128,
        TheWorldStoneKeepLevel2 = 129,
        TheWorldStoneKeepLevel3 = 130,
        ThroneOfDestruction = 131,
        TowerCellarLevel1 = 21,
        TowerCellarLevel2 = 22,
        TowerCellarLevel3 = 23,
        TowerCellarLevel4 = 24,
        TowerCellarLevel5 = 25,
        Travincal = 83,
        Tristram = 38,
        UberTristram = 136,
        UndergroundPassageLevel1 = 10,
        UndergroundPassageLevel2 = 14,
        UpperKurast = 81,
        ValleyOfSnakes = 45,
        MapsAncientTemple = 137,
        MapsDesecratedTemple = 138,
        MapsFrigidPlateau = 139,
        MapsInfernalTrial = 140,
        MapsRuinedCitadel = 141,
    }

    public static class AreaExtensions
    {
        private readonly static Dictionary<int, string> _areaNames = new Dictionary<int, string>()
        {
            {0, "None"},
            {1, "Rogue Encampment"},
            {2, "Blood Moor"},
            {3, "Cold Plains"},
            {4, "Stony Field"},
            {5, "Dark Wood"},
            {6, "Black Marsh"},
            {7, "Tamoe Highland"},
            {8, "Den Of Evil"},
            {9, "Cave Level 1"},
            {10, "Underground Passage Level 1"},
            {11, "Hole Level 1"},
            {12, "Pit Level 1"},
            {13, "Cave Level 2"},
            {14, "Underground Passage Level 2"},
            {15, "Hole Level 2"},
            {16, "Pit Level 2"},
            {17, "Burial Grounds"},
            {18, "Crypt"},
            {19, "Mausoleum"},
            {20, "Forgotten Tower"},
            {21, "Tower Cellar Level 1"},
            {22, "Tower Cellar Level 2"},
            {23, "Tower Cellar Level 3"},
            {24, "Tower Cellar Level 4"},
            {25, "Tower Cellar Level 5"},
            {26, "Monastery Gate"},
            {27, "Outer Cloister"},
            {28, "Barracks"},
            {29, "Jail Level 1"},
            {30, "Jail Level 2"},
            {31, "Jail Level 3"},
            {32, "Inner Cloister"},
            {33, "Cathedral"},
            {34, "Catacombs Level 1"},
            {35, "Catacombs Level 2"},
            {36, "Catacombs Level 3"},
            {37, "Catacombs Level 4"},
            {38, "Tristram"},
            {39, "Moo Moo Farm"},
            {40, "Lut Gholein"},
            {41, "Rocky Waste"},
            {42, "Dry Hills"},
            {43, "Far Oasis"},
            {44, "Lost City"},
            {45, "Valley Of Snakes"},
            {46, "Canyon Of The Magi"},
            {47, "A2 Sewers Level 1"},
            {48, "A2 Sewers Level 2"},
            {49, "A2 Sewers Level 3"},
            {50, "Harem Level 1"},
            {51, "Harem Level 2"},
            {52, "Palace Cellar Level 1"},
            {53, "Palace Cellar Level 2"},
            {54, "Palace Cellar Level 3"},
            {55, "Stony Tomb Level 1"},
            {56, "Halls Of The Dead Level 1"},
            {57, "Halls Of The Dead Level 2"},
            {58, "Claw Viper Temple Level 1"},
            {59, "Stony Tomb Level 2"},
            {60, "Halls Of The Dead Level 3"},
            {61, "Claw Viper Temple Level 2"},
            {62, "Maggot Lair Level 1"},
            {63, "Maggot Lair Level 2"},
            {64, "Maggot Lair Level 3"},
            {65, "Ancient Tunnels"},
            {66, "Tal Rashas Tomb #1"},
            {67, "Tal Rashas Tomb #2"},
            {68, "Tal Rashas Tomb #3"},
            {69, "Tal Rashas Tomb #4"},
            {70, "Tal Rashas Tomb #5"},
            {71, "Tal Rashas Tomb #6"},
            {72, "Tal Rashas Tomb #7"},
            {73, "Duriels Lair"},
            {74, "Arcane Sanctuary"},
            {75, "Kurast Docktown"},
            {76, "Spider Forest"},
            {77, "Great Marsh"},
            {78, "Flayer Jungle"},
            {79, "Lower Kurast"},
            {80, "Kurast Bazaar"},
            {81, "Upper Kurast"},
            {82, "Kurast Causeway"},
            {83, "Travincal"},
            {84, "Spider Cave"},
            {85, "Spider Cavern"},
            {86, "Swampy Pit Level 1"},
            {87, "Swampy Pit Level 2"},
            {88, "Flayer Dungeon Level 1"},
            {89, "Flayer Dungeon Level 2"},
            {90, "Swampy Pit Level 3"},
            {91, "Flayer Dungeon Level 3"},
            {92, "A3 Sewers Level 1"},
            {93, "A3 Sewers Level 2"},
            {94, "Ruined Temple"},
            {95, "Disused Fane"},
            {96, "Forgotten Reliquary"},
            {97, "Forgotten Temple"},
            {98, "Ruined Fane"},
            {99, "Disused Reliquary"},
            {100, "Durance Of Hate Level 1"},
            {101, "Durance Of Hate Level 2"},
            {102, "Durance Of Hate Level 3"},
            {103, "The Pandemonium Fortress"},
            {104, "Outer Steppes"},
            {105, "Plains Of Despair"},
            {106, "City Of The Damned"},
            {107, "River Of Flame"},
            {108, "Chaos Sanctuary"},
            {109, "Harrogath"},
            {110, "Bloody Foothills"},
            {111, "Frigid Highlands"},
            {112, "Arreat Plateau"},
            {113, "Crystalline Passage"},
            {114, "Frozen River"},
            {115, "Glacial Trail"},
            {116, "Drifter Cavern"},
            {117, "Frozen Tundra"},
            {118, "Ancient\'s Way"},
            {119, "Icy Cellar"},
            {120, "Arreat Summit"},
            {121, "Nihlathaks Temple"},
            {122, "Halls Of Anguish"},
            {123, "Halls Of Pain"},
            {124, "Halls Of Vaught"},
            {125, "Abaddon"},
            {126, "Pit Of Acheron"},
            {127, "Infernal Pit"},
            {128, "The Worldstone Keep Level 1"},
            {129, "The Worldstone Keep Level 2"},
            {130, "The Worldstone Keep Level 3"},
            {131, "Throne Of Destruction"},
            {132, "The Worldstone Chamber"},
            {133, "Matron\'s Den"},
            {134, "Fogotten Sands"},
            {135, "Furnace of Pain"},
            {136, "Tristram"}
        };

        public static string Name(this Area area)
        {
            return _areaNames.TryGetValue((int)area, out var areaName) ? areaName : area.ToString();
        }

        public static bool IsValid(this Area area)
        {
            return (uint)area >= 1 && (uint)area <= 136;
        }
    }
}
