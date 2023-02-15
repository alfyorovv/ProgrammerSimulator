using UnityEngine;
using UnityEngine.UI;

public class TapsProgressBar : MonoBehaviour
{
    [SerializeField] private Image tapsProgressBar;
    [SerializeField] private int targetTaps = 10;
    private int taps = 0;

    public void FillingProgressBar()
    {
        taps++;
        tapsProgressBar.fillAmount = taps / (float)targetTaps;
    }
    public bool IsProgrammReady()
    {
        if (taps == targetTaps)
        {
            taps = 0;
            tapsProgressBar.fillAmount = 0;
            return true;
        }
        else 
            return false;

    }    
}
