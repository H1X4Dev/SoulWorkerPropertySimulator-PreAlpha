using System;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IAttackComputeService
    {
        public (decimal Top, decimal Bottom) Get(int     enemyLevel,
                                                 int     enemyDefense,
                                                 decimal enemyCriticalResistance,
                                                 int     enemyEvade,
                                                 int     maxAttack,
                                                 decimal criticalRate,
                                                 int     criticalDamage,
                                                 int     accuracy,
                                                 decimal partialDamage,
                                                 decimal armorBreak,
                                                 decimal extraDamage);

        (decimal Top, decimal Bottom) Get65(int     maxAttack,
                                            decimal criticalRate,
                                            int     criticalDamage,
                                            int     accuracy,
                                            decimal partialDamage,
                                            decimal armorBreak,
                                            decimal extraDamage);

        (decimal Top, decimal Bottom) Get68(int     maxAttack,
                                            decimal criticalRate,
                                            int     criticalDamage,
                                            int     accuracy,
                                            decimal partialDamage,
                                            decimal armorBreak,
                                            decimal extraDamage);

        (decimal Top, decimal Bottom) Get72(int     maxAttack,
                                            decimal criticalRate,
                                            int     criticalDamage,
                                            int     accuracy,
                                            decimal partialDamage,
                                            decimal armorBreak,
                                            decimal extraDamage);
    }

    internal class AttackComputeService : IAttackComputeService
    {
        public (decimal Top, decimal Bottom) Get(int     enemyLevel,
                                                 int     enemyDefense,
                                                 decimal enemyCriticalResistance,
                                                 int     enemyEvade,
                                                 int     maxAttack,
                                                 decimal criticalRate,
                                                 int     criticalDamage,
                                                 int     accuracy,
                                                 decimal partialDamage,
                                                 decimal armorBreak,
                                                 decimal extraDamage)
        {
            if (accuracy > enemyEvade) { criticalRate += (accuracy - enemyEvade) / 50m; }

            criticalRate -= enemyCriticalResistance;
            criticalRate = criticalRate switch
            {
                > 1 => 1,
                < 0 => 0,
                _   => criticalRate
            };

            var hitRate = (accuracy - enemyEvade) / 1000m;
            hitRate = hitRate switch
            {
                > 1 => 1,
                < 0 => 0,
                _   => hitRate
            };

            return (Math.Floor(Calculate(maxAttack)), Math.Floor(Calculate(maxAttack * .8m)));

            decimal Calculate(decimal atk) =>
                (1                                               + extraDamage)             *
                (1                                               - CalculateEnemyDefense()) *
                (hitRate * (criticalRate * criticalDamage + atk) + (1 - hitRate) * atk * partialDamage);

            decimal CalculateEnemyDefense()
            {
                armorBreak = armorBreak switch
                {
                    > 1 => 1,
                    < 0 => 0,
                    _   => armorBreak
                };

                return enemyDefense * (1 - armorBreak) / (enemyDefense * (1 - armorBreak) + 50 * enemyLevel);
            }
        }

        public (decimal Top, decimal Bottom) Get65(int     maxAttack,
                                                   decimal criticalRate,
                                                   int     criticalDamage,
                                                   int     accuracy,
                                                   decimal partialDamage,
                                                   decimal armorBreak,
                                                   decimal extraDamage) =>
            Get(68,
                2600,
                0,
                800,
                maxAttack,
                criticalRate,
                criticalDamage,
                accuracy,
                partialDamage,
                armorBreak,
                extraDamage);

        public (decimal Top, decimal Bottom) Get68(int     maxAttack,
                                                   decimal criticalRate,
                                                   int     criticalDamage,
                                                   int     accuracy,
                                                   decimal partialDamage,
                                                   decimal armorBreak,
                                                   decimal extraDamage) =>
            Get(72,
                2850,
                0,
                1100,
                maxAttack,
                criticalRate,
                criticalDamage,
                accuracy,
                partialDamage,
                armorBreak,
                extraDamage);

        public (decimal Top, decimal Bottom) Get72(int     maxAttack,
                                                   decimal criticalRate,
                                                   int     criticalDamage,
                                                   int     accuracy,
                                                   decimal partialDamage,
                                                   decimal armorBreak,
                                                   decimal extraDamage) =>
            Get(677,
                4510,
                10,
                1200,
                maxAttack,
                criticalRate,
                criticalDamage,
                accuracy,
                partialDamage,
                armorBreak,
                extraDamage);
    }
}