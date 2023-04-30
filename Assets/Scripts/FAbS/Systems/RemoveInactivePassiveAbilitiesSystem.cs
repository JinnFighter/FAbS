using FAbS.Components;
using Leopotam.Ecs;

namespace FAbS.Systems
{
    internal class RemoveInactivePassiveAbilitiesSystem : IEcsRunSystem
    {
        private readonly EcsFilter<PassiveAbilityContainer> _filter = null;

        public void Run()
        {
            foreach (var index in _filter)
                if (!_filter.Get1(index).PassiveAbility.IsActive)
                    _filter.GetEntity(index).Del<PassiveAbilityContainer>();
        }
    }
}