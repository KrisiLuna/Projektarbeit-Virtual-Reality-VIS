using System;
using UnityEngine;

public class CandleFlicker : MonoBehaviour
{
    public Light candleLight;
    public float minIntensity = 0.1f;
    public float maxIntensity = 0.2f;
    public float flickerSpeed = 0.1f;

    void Update()
    {
        if (candleLight != null)
        {
            candleLight.intensity = Mathf.Lerp(
                candleLight.intensity,
                UnityEngine.Random.Range(minIntensity, maxIntensity),
                flickerSpeed
            );
        }
    }
}
