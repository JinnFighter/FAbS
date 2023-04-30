namespace FAbS.AbilityTypes
{
    public interface IPassiveAbility : IAbility
    {
        bool IsActive { get; }
        void SetActive(bool isActive);
    }
}