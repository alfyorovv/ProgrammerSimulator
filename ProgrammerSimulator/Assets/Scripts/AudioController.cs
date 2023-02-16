using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource key1, key2, key3;
    [SerializeField] private AudioClip clip1, clip2, clip3;

    public void PlayRandomKeySound()
    {
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0: key1.PlayOneShot(clip1);
                break;
            case 1: key2.PlayOneShot(clip2);
                break;
            case 2: key3.PlayOneShot(clip3);
                break;
        }
    }

    
}
