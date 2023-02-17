using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private bool soundEnabled;
    private AudioSource audioSource;
    [SerializeField] private Sprite sprite1, sprite2;
    [SerializeField] private Button soundButton;

    private void Awake()
    {
       // audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if (AudioListener.volume == 1)
            soundEnabled = true;
        else
            soundEnabled = false;

        if (soundEnabled)
        {
            soundButton.image.sprite = sprite1;
        }
        else
        {
            soundButton.image.sprite = sprite2;
        }
    }

    public void SwitchSound()
    {
        if (soundEnabled)
        {
            AudioListener.volume = 0;
            soundEnabled = !soundEnabled;
            soundButton.image.sprite = sprite2;
        }
        else
        {
            AudioListener.volume = 1f;
            soundEnabled = !soundEnabled;
            soundButton.image.sprite = sprite1;
        }
    }
}
