using UnityEngine;
using UnityEngine.UI;

public class TapsProgressBar : MonoBehaviour
{
    [SerializeField] private Image tapsProgressBar;
    [SerializeField] private int targetTaps = 10;

    private void Start()
    {
        tapsProgressBar.fillAmount = PlayerPrefs.GetInt("taps") / (float)targetTaps;
    }

    public void FillingProgressBar()
    {
        PlayerPrefs.SetInt("taps", PlayerPrefs.GetInt("taps") + 1);
        tapsProgressBar.fillAmount = PlayerPrefs.GetInt("taps") / (float)targetTaps;
    }
    public bool IsProgrammReady()
    {
        if (PlayerPrefs.GetInt("taps") == targetTaps)
        {
            PlayerPrefs.SetInt("taps", 0);
            tapsProgressBar.fillAmount = 0;
            return true;
        }
        else 
            return false;

    }    
}
