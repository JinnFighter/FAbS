using FAbS.AbilityTypes;
using Leopotam.Ecs;

namespace FAbS.Components
{
    public struct AddPassiveAbilityEvent : IEcsAutoReset<AddPassiveAbilityEvent>
    {
        public PassiveAbility PassiveAbility;

        public void AutoReset(ref AddPassiveAbilityEvent c)
        {
            c.PassiveAbility = null;
        }
    }
}