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

        private void Update()
        {
            _abilitySystem?.Update();
        }

        private void OnDestroy()
        {
            _abilitySystem?.Dispose();
        }

        private IEnumerator LoggingCoroutine()
        {
            var time = 3f;
            var loggingPassiveAbility = new LoggingPassiveAbility();
            _abilitySystem.AddPassiveAbility(loggingPassiveAbility);
            while (time > 0f)
            {
                yield return new WaitForSeconds(0.5f);
                time -= 0.5f;

                if (time <= 0f)
                {
                    _abilitySystem.RemovePassiveAbility(loggingPassiveAbility);
                }
            }
        }
    }
}