using FAbS.Components;
using Leopotam.Ecs;

namespace FAbS.Systems
{
    public class AddPassiveAbilitySystem : IEcsRunSystem
    {
        private readonly EcsFilter<AddPassiveAbilityEvent> _filter = null;
        private readonly EcsWorld _world = null;

        public void Run()
        {
            foreach (var index in _filter)
            {
                var abilityEvent = _filter.Get1(index);
                var entity = _world.NewEntity();
                ref var passiveAbilityContainer = ref entity.Get<PassiveAbilityContainer>();
                passiveAbilityContainer.PassiveAbility = abilityEvent.PassiveAbility;
                passiveAbilityContainer.PassiveAbility.Activate();
            }
        }
    }
}