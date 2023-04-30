namespace FAbS.AbilityTypes
{
    public abstract class PassiveAbility : IPassiveAbility
    {
        public bool IsActive { get; private set; } = true;

        public void SetActive(bool isActive)
        {
            IsActive = isActive;
        }
    }
}