using System;
using FAbS.AbilityTypes;

namespace FAbS
{
    internal interface IAbilitySystem : IDisposable
    {
        bool IsInitialized { get; }
        void Initialize();
        void Update();
        void AddPassiveAbility(PassiveAbility passiveAbility);
        void RemovePassiveAbility(PassiveAbility passiveAbility);
    }
}