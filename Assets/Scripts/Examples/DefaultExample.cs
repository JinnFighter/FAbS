using System.Collections;
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

            StartCoroutine(LoggingCoroutine());
        }

        public IEnumerator LoggingCoroutine()
        {
            var time = 3f;
            var loggingPassiveAbility = new LoggingPassiveAbility();
            _abilitySystem.AddPassiveAbility(loggingPassiveAbility);
            while (loggingPassiveAbility.IsActive)
            {
                Debug.Log("Logging ability active...");
                yield return new WaitForSeconds(0.5f);
                time -= 0.5f;

                if (!(time <= 0f)) continue;
                Debug.Log("Stopping logging...");
                _abilitySystem.RemovePassiveAbility(loggingPassiveAbility);
            }
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