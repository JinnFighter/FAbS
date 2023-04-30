using FAbS;
using UnityEngine;

namespace Examples
{
    public class DefaultExample : MonoBehaviour
    {
        private AbilitySystem _abilitySystem;

        private void Start()
        {
            _abilitySystem = new AbilitySystem();
            _abilitySystem.Initialize();
        }

        private void Update()
        {
            _abilitySystem?.Update();
        }

        private void OnDestroy()
        {
            _abilitySystem?.Dispose();
        }
    }
}