using UnityEngine;

public class TapController : MonoBehaviour
{
    
    private TapsProgressBar tapsProgressBar;
    private Keys keys;
    private AudioController audioController;
    private ProgrammerAnimation programmerAnimation;
    private void Awake()
    {
        tapsProgressBar = FindObjectOfType<TapsProgressBar>();
        keys = FindObjectOfType<Keys>();
        audioController = FindObjectOfType<AudioController>();
      programmerAnimation = FindObjectOfType<ProgrammerAnimation>();
    }
    private void Update()
    {
        CheckMouseClick();
    }

    private void CheckMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tapsProgressBar.FillingProgressBar();
            keys.SpawnKey();
            audioController.PlayRandomKeySound();
            programmerAnimation.AnimationNextFrame();
        }   
        /*if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                tapsProgressBar.FillingProgressBar();
                keys.SpawnKey();
                audioController.PlayRandomKeySound();
                programmerAnimation.AnimationNextFrame();
            }*/
    }
}



    
