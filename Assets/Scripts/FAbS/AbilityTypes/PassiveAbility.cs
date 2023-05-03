using UnityEngine.Events;

namespace FAbS.AbilityTypes
{
    public abstract class PassiveAbility : IPassiveAbility
    {
        public bool IsActive { get; private set; }

        public void Activate()
        {
            if (IsActive) return;

            ActivateInternal();
            IsActive = true;
            AbilityActivated.Invoke();
        }

        public void Deactivate()
        {
            if (!IsActive) return;

            DeactivateInternal();
            IsActive = false;
            AbilityDeactivated.Invoke();
        }

        public UnityEvent AbilityActivated { get; } = new();
        public UnityEvent AbilityDeactivated { get; } = new();

        protected virtual void ActivateInternal()
        {
        }

        protected virtual void DeactivateInternal()
        {
        }
    }
}