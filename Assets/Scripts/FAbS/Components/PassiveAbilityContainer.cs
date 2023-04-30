using FAbS.AbilityTypes;
using Leopotam.Ecs;

namespace FAbS.Components
{
    public struct PassiveAbilityContainer : IEcsAutoReset<PassiveAbilityContainer>
    {
        public PassiveAbility PassiveAbility;

        public void AutoReset(ref PassiveAbilityContainer c)
        {
            c.PassiveAbility = null;
        }
    }
}