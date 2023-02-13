using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TapController : MonoBehaviour
{

    private int taps = 0;
    [SerializeField] private int targetTaps = 10;
    [SerializeField] private Text tapsText;
    [SerializeField] private UnityEngine.UI.Image progressBar;

    
   private void Start()
    {
        
    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            taps++;
            tapsText.text = "Taps: " + taps.ToString();
            progressBar.fillAmount = (float)taps / 10;
           
        } 
            
    }

}
