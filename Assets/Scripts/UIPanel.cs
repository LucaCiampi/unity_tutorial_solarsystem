using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{
    public UnityEngine.UI.Button pauseButton;
    public UnityEngine.UI.Slider speedSlider;
    public TMPro.TextMeshProUGUI speedLabel;
    
    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance.OnSpeedChanged += UpdateSpeedLabel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void UpdateSpeedLabel(float newspeed)
    {
        this.speedLabel.text = "Speed : " + newspeed.ToString();
    }
}
