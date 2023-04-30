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
            _globalSystems.Init();
            IsInitialized = true;
        }

        public void Update()
        {
            if (IsInitialized) _globalSystems.Run();
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