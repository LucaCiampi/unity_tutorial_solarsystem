using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InputController : MonoBehaviour
{
    private static InputController _instance = null;
    public static InputController Instance
    {
        get
        {
            if (!_instance) _instance = FindObjectOfType<InputController>();
            return _instance;
        }
        private set
        {
            _instance = value;
        }
    }

    public delegate void InputSpecificEvent();
    public event InputSpecificEvent OnUserPause;
    
    // Start is called before the first frame update
    void Start()
    {
        if (InputController.Instance == null) InputController.Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) this.OnUserPause.Invoke();
    }
}