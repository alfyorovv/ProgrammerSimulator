using UnityEngine;

public class TapController : MonoBehaviour
{
    
    private TapsProgressBar tapsProgressBar;
    private Keys keys;
    private AudioController audioController;

    private void Awake()
    {
        tapsProgressBar = FindObjectOfType<TapsProgressBar>();
        keys = FindObjectOfType<Keys>();
        audioController = FindObjectOfType<AudioController>();
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
        }
    }

}

    
