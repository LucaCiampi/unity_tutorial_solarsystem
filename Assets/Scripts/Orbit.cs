using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public PlanetOrbitPreset preset;
    [Tooltip("Child planet to move")]
    public GameObject planet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Rotate();
        this.SetPlanetDistance();
    }

    /**
     * Makes the planet rotate on itself
     */
    private void Rotate()
    {
        float _dt = Time.deltaTime;
        
        float _angle = this.preset.orbitalSpeed * _dt;

        if (GameController.Instance) _angle *= GameController.Instance.speed;

        this.transform.Rotate(Vector3.up, _angle, Space.Self);
    }
    
    /**
     * Sets the planet a certain distance from the sun
     */
    private void SetPlanetDistance()
    {
        this.planet.transform.localPosition = new Vector3(0, 0, this.preset.orbitRadius);
    }
}
