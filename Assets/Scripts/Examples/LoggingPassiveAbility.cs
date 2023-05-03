using FAbS.AbilityTypes;
using UnityEngine;

namespace Examples
{
    public class LoggingPassiveAbility : PassiveAbility
    {
        protected override void ActivateInternal()
        {
            Debug.Log("Logging activated...");
        }

        protected override void DeactivateInternal()
        {
            Debug.Log("Logging deactivated...");
        }
    }
}