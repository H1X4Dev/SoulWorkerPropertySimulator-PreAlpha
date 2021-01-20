using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class CharacterData
    {
        private static IReadOnlyCollection<Character>? _result;

        // All character's accuracy now based Erwin's
        private static readonly int[] AccuracyList =
        {
            804, //1
            808,
            811,
            815,
            819, //5
            823,
            826,
            830,
            835,
            839, //10
            842,
            846,
            850,
            854,
            857, //15
            861,
            866,
            870,
            873,
            877, //20
            881,
            885,
            888,
            892,
            897, //25
            901,
            904,
            908,
            912,
            916, //30
            919,
            923,
            928,
            932,
            935, //35
            939,
            943,
            947,
            950,
            954, //40
            959,
            963,
            966,
            970,
            974, //45
            978,
            981,
            985,
            990,
            994, //50
            997,
            1001,
            1005,
            1009,
            1012, //55
            1016,
            1021,
            1025,
            1028,
            1032, //60
            1036,
            1040,
            1043,
            1047,
            1051, //65
            1055,
            1058,
            1062
        };

        public static IReadOnlyCollection<Character> Get()
        {
            if (_result != null) { return _result; }

            var result = new List<Character>
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

            _result = result;
            return _result;
        }
    }
}