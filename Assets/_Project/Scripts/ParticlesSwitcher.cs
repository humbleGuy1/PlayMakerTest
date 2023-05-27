using System.Collections;
using UnityEngine;

public class ParticlesHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particle1;
    [SerializeField] private ParticleSystem _particle2;
    [SerializeField] private float _switchTime;

    private void Start()
    {
        StartCoroutine(SwitchParticles(_particle1, _particle2));
    }

    private IEnumerator SwitchParticles(ParticleSystem particle1, ParticleSystem particle2)
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_switchTime);

        while (true)
        {
            particle2.Stop();

            yield return waitForSeconds;

            particle1.Play();

            yield return waitForSeconds;

            particle1.Stop();

            yield return waitForSeconds;

            particle2.Play();

            yield return waitForSeconds;
        }
    }
}
