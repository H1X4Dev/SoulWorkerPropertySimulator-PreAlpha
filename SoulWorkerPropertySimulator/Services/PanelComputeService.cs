using System.Collections.Generic;
using System.Linq;
using SoulWorkerPropertySimulator.Models.Effects;

namespace SoulWorkerPropertySimulator.Services
{
    public interface IPanelComputeService : IComputeService
    {
        IDictionary<EffectContext, decimal> Get();
        decimal?                            Get(EffectContext context);
    }

    internal class PanelComputeService : ComputeServiceBase, IPanelComputeService
    {
        // private readonly IAccessoryComputeService  _accessory;
        // private readonly IAkashaComputeService     _akasha;
        // private readonly IEquipmentComputeService      _armor;
        // private readonly IBroochesComputeService   _brooches;
        // private readonly ICharacterComputeService _character;
        private readonly IAttackComputeService _attack;

        public PanelComputeService(IAccessoryComputeService accessory,
                                   IAkashaComputeService    akasha,
                                   IEquipmentComputeService equipment,
                                   IBroochesComputeService  brooches,
                                   ICharacterComputeService character,
                                   IAttackComputeService    attack)
        {
            // _accessory = accessory;
            // _akasha    = akasha;
            // _armor     = equipment;
            // _brooches  = brooches;
            // _character = character;
            _attack = attack;

            accessory.OnChange += Change;
            akasha.OnChange    += Change;
            equipment.OnChange += Change;
            brooches.OnChange  += Change;
            character.OnChange += Change;
        }

        public IDictionary<EffectContext, decimal> Get() => Effect.ToDictionary(x => x.Key, x => x.Value);

        public decimal? Get(EffectContext context)
        {
            try { return Effect[context]; }
            catch (KeyNotFoundException) { return null; }
        }

        public void Change(EffectContext context, decimal value)
        {
            Effect[context] = value;
            Invoke(context, value);
        }
    }
}