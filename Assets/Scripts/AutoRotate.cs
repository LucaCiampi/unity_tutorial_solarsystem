using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float speed = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Rotate();
    }

    /**
     * Makes the planet rotate on itself
     */
    private void Rotate()
    {
        float _dt = Time.deltaTime;
        
        float _angle = this.speed * _dt;

        if (GameController.Instance) _angle *= GameController.Instance.speed;

        this.transform.Rotate(Vector3.up, _angle, Space.Self);
    }
}
