using System;
using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models;
using SoulWorkerPropertySimulator.Models.Effects;
using SoulWorkerPropertySimulator.Services.Scaffolding;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IPanelComputeService : IComputeService
    {
        IReadOnlyCollection<Effect>      GetStatic();
        decimal?                         GetStatic(EffectContext context);
        IReadOnlyDictionary<Effect, int> GetNonStatic();
    }

    internal class PanelComputeService : ComputeServiceBase, IPanelComputeService
    {
        private readonly IAttackComputeService    _attack;
        private readonly ICharacterComputeService _character;

        public PanelComputeService(IAccessorySetComputeService accessorySet,
                                   IAkashaComputeService       akasha,
                                   IEquipmentComputeService    equipment,
                                   IBroochesSetComputeService  broochesSet,
                                   ICharacterComputeService    character,
                                   IAttackComputeService       attack)
        {
            // _accessory = accessorySet;
            // _akasha    = akasha;
            // _armor     = equipment;
            // _brooches  = broochesSet;
            _attack    = attack;
            _character = character;

            accessorySet.OnStaticChange    += StaticChange;
            akasha.OnStaticChange          += StaticChange;
            equipment.OnStaticChange       += StaticChange;
            broochesSet.OnStaticChange     += StaticChange;
            character.OnStaticChange       += StaticChange;
            accessorySet.OnNonStaticChange += NonStaticChange;
            akasha.OnNonStaticChange       += NonStaticChange;
            equipment.OnNonStaticChange    += NonStaticChange;
            broochesSet.OnNonStaticChange  += NonStaticChange;
            character.OnNonStaticChange    += NonStaticChange;
        }

        public IReadOnlyCollection<Effect> GetStatic()
        {
            var addition = new List<Effect>();
            StaticEffect.ToList()
                .ForEach(x =>
                {
                    try
                    {
                        var (context, value) = x;
                        if (HandleSpecific(context, out var newValue)) { addition.Add(new(context, newValue)); }
                        else { addition.Add(new(context, value)); }
                    }
                    catch (InvalidOperationException) { }
                });

            return addition.Where(x => x.Value != 0).ToList();
        }

        public decimal? GetStatic(EffectContext context)
        {
            try { return HandleSpecific(context, out var result) ? result : SafeReadStaticEffect(context); }
            catch (InvalidOperationException) { return null; }
        }

        public IReadOnlyDictionary<Effect, int> GetNonStatic() =>
            NonStaticEffect.Where(x => x.Value != 0).ToDictionary(x => x.Key, x => x.Value);

        private bool HandleSpecific(EffectContext context, out decimal value)
        {
            if (context.Equals(StaticEffectContext.CriticalDamage))
            {
                var criticalDamage = SafeReadStaticEffect(StaticEffectContext.CriticalDamage) ?? 0;
                var attack         = SafeReadStaticEffect(StaticEffectContext.Attack)         ?? 0;

                value = (int) (criticalDamage + attack * .8m);
                return true;
            }

            if (context.Equals(StaticEffectContext.Hp))
            {
                var hp     = SafeReadStaticEffect(StaticEffectContext.Hp)     ?? 0;
                var hpRate = SafeReadStaticEffect(StaticEffectContext.HpRate) ?? 0;
                var baseHp = _character.Get()!.BaseEffect.First(x => x.Context.Equals(StaticEffectContext.Hp)).Value;

                value = (int) (hp + baseHp * hpRate);
                return true;
            }

            if (context.Equals(StaticEffectContext.HpRate))
            {
                throw new ApplicationInvalidOperationException(StaticEffectContext.Hp);
            }

            if (context.Equals(StaticEffectContext.WeaponAttack)     ||
                context.Equals(StaticEffectContext.WeaponAttackRate) ||
                context.Equals(StaticEffectContext.GearDefense)      ||
                context.Equals(StaticEffectContext.GearDefenseRate))
            {
                Console.WriteLine($"WARN: Context {context} not handle correctly");
                value = 0;
                throw new InvalidOperationException();
            }

            value = 0;
            return false;
        }

        public void StaticChange(EffectContext context, decimal value)
        {
            if (!StaticEffect.ContainsKey(context)) { StaticEffect[context] =  value; }
            else { StaticEffect[context]                                    += value; }

            Invoke(context);

            void Invoke(EffectContext c)
            {
                try { InvokeStatic(c, HandleSpecific(c, out var newValue) ? newValue : StaticEffect[c]); }
                catch (ApplicationInvalidOperationException e) { Invoke((EffectContext) e.CustomData); }
                catch (InvalidOperationException) { }
            }
        }

        public void NonStaticChange(Effect effect, int value)
        {
            if (!NonStaticEffect.ContainsKey(effect)) { NonStaticEffect[effect] =  value; }
            else { NonStaticEffect[effect]                                      += value; }

            InvokeNonStatic(effect, NonStaticEffect[effect]);
        }

        private decimal? SafeReadStaticEffect(EffectContext context)
        {
            try { return StaticEffect[context]; }
            catch (KeyNotFoundException) { return null; }
        }
    }
}