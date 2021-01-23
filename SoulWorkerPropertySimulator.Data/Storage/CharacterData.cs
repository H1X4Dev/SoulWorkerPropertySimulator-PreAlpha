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
            new(StaticEffectContext.Accuracy, 804), //1
            new(StaticEffectContext.Accuracy, 808),
            new(StaticEffectContext.Accuracy, 811),
            new(StaticEffectContext.Accuracy, 815),
            new(StaticEffectContext.Accuracy, 819), //5
            new(StaticEffectContext.Accuracy, 823),
            new(StaticEffectContext.Accuracy, 826),
            new(StaticEffectContext.Accuracy, 830),
            new(StaticEffectContext.Accuracy, 835),
            new(StaticEffectContext.Accuracy, 839), //10
            new(StaticEffectContext.Accuracy, 842),
            new(StaticEffectContext.Accuracy, 846),
            new(StaticEffectContext.Accuracy, 850),
            new(StaticEffectContext.Accuracy, 854),
            new(StaticEffectContext.Accuracy, 857), //15
            new(StaticEffectContext.Accuracy, 861),
            new(StaticEffectContext.Accuracy, 866),
            new(StaticEffectContext.Accuracy, 870),
            new(StaticEffectContext.Accuracy, 873),
            new(StaticEffectContext.Accuracy, 877), //20
            new(StaticEffectContext.Accuracy, 881),
            new(StaticEffectContext.Accuracy, 885),
            new(StaticEffectContext.Accuracy, 888),
            new(StaticEffectContext.Accuracy, 892),
            new(StaticEffectContext.Accuracy, 897), //25
            new(StaticEffectContext.Accuracy, 901),
            new(StaticEffectContext.Accuracy, 904),
            new(StaticEffectContext.Accuracy, 908),
            new(StaticEffectContext.Accuracy, 912),
            new(StaticEffectContext.Accuracy, 916), //30
            new(StaticEffectContext.Accuracy, 919),
            new(StaticEffectContext.Accuracy, 923),
            new(StaticEffectContext.Accuracy, 928),
            new(StaticEffectContext.Accuracy, 932),
            new(StaticEffectContext.Accuracy, 935), //35
            new(StaticEffectContext.Accuracy, 939),
            new(StaticEffectContext.Accuracy, 943),
            new(StaticEffectContext.Accuracy, 947),
            new(StaticEffectContext.Accuracy, 950),
            new(StaticEffectContext.Accuracy, 954), //40
            new(StaticEffectContext.Accuracy, 959),
            new(StaticEffectContext.Accuracy, 963),
            new(StaticEffectContext.Accuracy, 966),
            new(StaticEffectContext.Accuracy, 970),
            new(StaticEffectContext.Accuracy, 974), //45
            new(StaticEffectContext.Accuracy, 978),
            new(StaticEffectContext.Accuracy, 981),
            new(StaticEffectContext.Accuracy, 985),
            new(StaticEffectContext.Accuracy, 990),
            new(StaticEffectContext.Accuracy, 994), //50
            new(StaticEffectContext.Accuracy, 997),
            new(StaticEffectContext.Accuracy, 1_001),
            new(StaticEffectContext.Accuracy, 1_005),
            new(StaticEffectContext.Accuracy, 1_009),
            new(StaticEffectContext.Accuracy, 1_012), //55
            new(StaticEffectContext.Accuracy, 1_016),
            new(StaticEffectContext.Accuracy, 1_021),
            new(StaticEffectContext.Accuracy, 1_025),
            new(StaticEffectContext.Accuracy, 1_028),
            new(StaticEffectContext.Accuracy, 1_032), //60
            new(StaticEffectContext.Accuracy, 1_036),
            new(StaticEffectContext.Accuracy, 1_040),
            new(StaticEffectContext.Accuracy, 1_043),
            new(StaticEffectContext.Accuracy, 1_047),
            new(StaticEffectContext.Accuracy, 1_051), //65
            new(StaticEffectContext.Accuracy, 1_055),
            new(StaticEffectContext.Accuracy, 1_058),
            new(StaticEffectContext.Accuracy, 1_062)
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