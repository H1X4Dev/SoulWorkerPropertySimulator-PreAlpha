using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        private static readonly IReadOnlyCollection<Character> Result;

        // All character's accuracy now based Erwin's
        private static readonly Effect[] AccuracyList =
        {
            new(Static.Accuracy, 804), //1
            new(Static.Accuracy, 808),
            new(Static.Accuracy, 811),
            new(Static.Accuracy, 815),
            new(Static.Accuracy, 819), //5
            new(Static.Accuracy, 823),
            new(Static.Accuracy, 826),
            new(Static.Accuracy, 830),
            new(Static.Accuracy, 835),
            new(Static.Accuracy, 839), //10
            new(Static.Accuracy, 842),
            new(Static.Accuracy, 846),
            new(Static.Accuracy, 850),
            new(Static.Accuracy, 854),
            new(Static.Accuracy, 857), //15
            new(Static.Accuracy, 861),
            new(Static.Accuracy, 866),
            new(Static.Accuracy, 870),
            new(Static.Accuracy, 873),
            new(Static.Accuracy, 877), //20
            new(Static.Accuracy, 881),
            new(Static.Accuracy, 885),
            new(Static.Accuracy, 888),
            new(Static.Accuracy, 892),
            new(Static.Accuracy, 897), //25
            new(Static.Accuracy, 901),
            new(Static.Accuracy, 904),
            new(Static.Accuracy, 908),
            new(Static.Accuracy, 912),
            new(Static.Accuracy, 916), //30
            new(Static.Accuracy, 919),
            new(Static.Accuracy, 923),
            new(Static.Accuracy, 928),
            new(Static.Accuracy, 932),
            new(Static.Accuracy, 935), //35
            new(Static.Accuracy, 939),
            new(Static.Accuracy, 943),
            new(Static.Accuracy, 947),
            new(Static.Accuracy, 950),
            new(Static.Accuracy, 954), //40
            new(Static.Accuracy, 959),
            new(Static.Accuracy, 963),
            new(Static.Accuracy, 966),
            new(Static.Accuracy, 970),
            new(Static.Accuracy, 974), //45
            new(Static.Accuracy, 978),
            new(Static.Accuracy, 981),
            new(Static.Accuracy, 985),
            new(Static.Accuracy, 990),
            new(Static.Accuracy, 994), //50
            new(Static.Accuracy, 997),
            new(Static.Accuracy, 1_001),
            new(Static.Accuracy, 1_005),
            new(Static.Accuracy, 1_009),
            new(Static.Accuracy, 1_012), //55
            new(Static.Accuracy, 1_016),
            new(Static.Accuracy, 1_021),
            new(Static.Accuracy, 1_025),
            new(Static.Accuracy, 1_028),
            new(Static.Accuracy, 1_032), //60
            new(Static.Accuracy, 1_036),
            new(Static.Accuracy, 1_040),
            new(Static.Accuracy, 1_043),
            new(Static.Accuracy, 1_047),
            new(Static.Accuracy, 1_051), //65
            new(Static.Accuracy, 1_055),
            new(Static.Accuracy, 1_058),
            new(Static.Accuracy, 1_062)
        };

        static CharacterData() =>
            Result = new List<Character>
            {
                Haru,
                Erwin,
                Lily,
                Stella,
                Jin,
                Iris,
                Chii,
                Erwin,
                Lee
            };

        public static IReadOnlyCollection<Character> Get() => Result;
    }
}