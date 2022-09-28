using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _instance = null;
    public static GameController Instance
    {
        get
        {
            if (!_instance) _instance = FindObjectOfType<GameController>();
            return _instance;
        }
        private set
        {
            _instance = value;
        }
    }
    
    [Range(-20, 20)] 
    public float speed = 1f;

    private float _previousSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this;

        InputController.Instance.OnUserPause += Pause;
        //if (InputController.Instance) InputController.Instance.OnUserInput("pause") += Pause;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /**
     * Pauses the game, setting the speed of the planets to 0
     */
    public void Pause()
    {
        if (this.speed != 0)
        {
            this._previousSpeed = this.speed;
            this.speed = 0;
        }
        else
        {
            if (this._previousSpeed == 0) this.speed = 1;
            else this.speed = this._previousSpeed;
        }
    }
}
