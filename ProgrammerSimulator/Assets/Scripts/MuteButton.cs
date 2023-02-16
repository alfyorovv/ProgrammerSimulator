using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

   

    private void Start()
    {
        soundOnImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            

        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn=true;
           
        }
    }
 }
