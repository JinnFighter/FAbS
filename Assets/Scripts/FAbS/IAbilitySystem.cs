using System;

namespace FAbS
{
    internal interface IAbilitySystem : IDisposable
    {
        bool IsInitialized { get; }
        void Initialize();
        void Update();
    }
}