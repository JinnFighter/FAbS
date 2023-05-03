using FAbS.AbilityTypes;
using Leopotam.Ecs;

namespace FAbS.Components
{
    internal struct PassiveAbilityContainer : IEcsAutoReset<PassiveAbilityContainer>
    {
        public PassiveAbility PassiveAbility;

        public void AutoReset(ref PassiveAbilityContainer c)
        {
            c.PassiveAbility = null;
        }
    }
}