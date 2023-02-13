using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TapController : MonoBehaviour
{

    private int taps = 0;
    [SerializeField] private Text tapsText;
    
   private void Start()
    {
        
    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            taps++;
            tapsText.text = "Taps: " + taps.ToString();
           
        } 
            
    }

}
