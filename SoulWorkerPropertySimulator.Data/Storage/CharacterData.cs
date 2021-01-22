using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        private static readonly IReadOnlyCollection<Character> Result;

        // All character's accuracy now based Erwin's
        private static readonly Effect[] AccuracyList =
        {
            new(StaticEffect.Accuracy, 804), //1
            new(StaticEffect.Accuracy, 808),
            new(StaticEffect.Accuracy, 811),
            new(StaticEffect.Accuracy, 815),
            new(StaticEffect.Accuracy, 819), //5
            new(StaticEffect.Accuracy, 823),
            new(StaticEffect.Accuracy, 826),
            new(StaticEffect.Accuracy, 830),
            new(StaticEffect.Accuracy, 835),
            new(StaticEffect.Accuracy, 839), //10
            new(StaticEffect.Accuracy, 842),
            new(StaticEffect.Accuracy, 846),
            new(StaticEffect.Accuracy, 850),
            new(StaticEffect.Accuracy, 854),
            new(StaticEffect.Accuracy, 857), //15
            new(StaticEffect.Accuracy, 861),
            new(StaticEffect.Accuracy, 866),
            new(StaticEffect.Accuracy, 870),
            new(StaticEffect.Accuracy, 873),
            new(StaticEffect.Accuracy, 877), //20
            new(StaticEffect.Accuracy, 881),
            new(StaticEffect.Accuracy, 885),
            new(StaticEffect.Accuracy, 888),
            new(StaticEffect.Accuracy, 892),
            new(StaticEffect.Accuracy, 897), //25
            new(StaticEffect.Accuracy, 901),
            new(StaticEffect.Accuracy, 904),
            new(StaticEffect.Accuracy, 908),
            new(StaticEffect.Accuracy, 912),
            new(StaticEffect.Accuracy, 916), //30
            new(StaticEffect.Accuracy, 919),
            new(StaticEffect.Accuracy, 923),
            new(StaticEffect.Accuracy, 928),
            new(StaticEffect.Accuracy, 932),
            new(StaticEffect.Accuracy, 935), //35
            new(StaticEffect.Accuracy, 939),
            new(StaticEffect.Accuracy, 943),
            new(StaticEffect.Accuracy, 947),
            new(StaticEffect.Accuracy, 950),
            new(StaticEffect.Accuracy, 954), //40
            new(StaticEffect.Accuracy, 959),
            new(StaticEffect.Accuracy, 963),
            new(StaticEffect.Accuracy, 966),
            new(StaticEffect.Accuracy, 970),
            new(StaticEffect.Accuracy, 974), //45
            new(StaticEffect.Accuracy, 978),
            new(StaticEffect.Accuracy, 981),
            new(StaticEffect.Accuracy, 985),
            new(StaticEffect.Accuracy, 990),
            new(StaticEffect.Accuracy, 994), //50
            new(StaticEffect.Accuracy, 997),
            new(StaticEffect.Accuracy, 1_001),
            new(StaticEffect.Accuracy, 1_005),
            new(StaticEffect.Accuracy, 1_009),
            new(StaticEffect.Accuracy, 1_012), //55
            new(StaticEffect.Accuracy, 1_016),
            new(StaticEffect.Accuracy, 1_021),
            new(StaticEffect.Accuracy, 1_025),
            new(StaticEffect.Accuracy, 1_028),
            new(StaticEffect.Accuracy, 1_032), //60
            new(StaticEffect.Accuracy, 1_036),
            new(StaticEffect.Accuracy, 1_040),
            new(StaticEffect.Accuracy, 1_043),
            new(StaticEffect.Accuracy, 1_047),
            new(StaticEffect.Accuracy, 1_051), //65
            new(StaticEffect.Accuracy, 1_055),
            new(StaticEffect.Accuracy, 1_058),
            new(StaticEffect.Accuracy, 1_062)
        };

        static CharacterData() =>
            Result = new List<Character>
            {
                SetupHaru(),
                SetupErwin(),
                SetupLily(),
                SetupStella(),
                SetupJin(),
                SetupIris(),
                SetupChii(),
                SetupEphnel(),
                SetupLee()
            };

        public static IReadOnlyCollection<Character> Get() => Result;
    }
}