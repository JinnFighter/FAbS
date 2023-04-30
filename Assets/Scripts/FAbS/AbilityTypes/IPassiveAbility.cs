using UnityEngine.Events;

namespace FAbS.AbilityTypes
{
    public interface IPassiveAbility : IAbility
    {
        bool IsActive { get; }
        void Activate();
        void Deactivate();
        UnityEvent AbilityActivated { get; }
        UnityEvent AbilityDeactivated { get; }
    }
}