using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlanetOrbitPreset : ScriptableObject
{
    [Range(-100, 100)]
    [Tooltip("Speed of rotation of the orbit in degrees per second")]
    public float orbitalSpeed;
    
    [Range(0, 5000)]
    [Tooltip("Distance of the orbit in millions of kilometers")]
    public float orbitRadius;
}
