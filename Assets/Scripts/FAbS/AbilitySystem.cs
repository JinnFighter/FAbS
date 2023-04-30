using FAbS.AbilityTypes;
using FAbS.Components;
using FAbS.Systems;
using Leopotam.Ecs;

namespace FAbS
{
    public class AbilitySystem : IAbilitySystem
    {
        private readonly EcsSystems _globalSystems;
        private readonly EcsWorld _world;

        public AbilitySystem()
        {
            _world = new EcsWorld();
            _globalSystems = new EcsSystems(_world);
        }

        public bool IsInitialized { get; private set; }

        public void Initialize()
        {
            _globalSystems
                .Add(new AddPassiveAbilitySystem())
                .Add(new RemoveInactivePassiveAbilitiesSystem())
                .OneFrame<AddPassiveAbilityEvent>()
                .Init();
            IsInitialized = true;
        }

        public void Update()
        {
            if (!IsInitialized) return;
            _globalSystems.Run();
        }

        public void AddPassiveAbility(PassiveAbility passiveAbility)
        {
            if (!IsInitialized) return;
            var entity = _world.NewEntity();
            ref var addPassiveAbilityEvent = ref entity.Get<AddPassiveAbilityEvent>();
            addPassiveAbilityEvent.PassiveAbility = passiveAbility;
        }

        public void RemovePassiveAbility(PassiveAbility passiveAbility)
        {
            if (!IsInitialized) return;
            passiveAbility.SetActive(false);
        }

        public void Dispose()
        {
            if (!IsInitialized) return;

            _globalSystems.Destroy();
            _world.Destroy();
            IsInitialized = false;
        }
    }
}