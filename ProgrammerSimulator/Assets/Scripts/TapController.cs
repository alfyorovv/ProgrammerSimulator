using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TapController : MonoBehaviour
{

    private int taps = 0;
    private int randomKey;
    private GameObject keyToSpawn;
    [SerializeField] private int targetTaps = 10;
    [SerializeField] private Text tapsText;
    [SerializeField] private UnityEngine.UI.Image progressBar;
    [SerializeField] private Sprite[] keys;


   private void Start()
    {
        
    }

    
    private void Update()
    {
        CheckMouseClick();
    }

    private void CheckMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FillingProgressBar();
            SpawnKey();
        }
    }

    private void FillingProgressBar()
    {
        taps++;
        tapsText.text = "Taps: " + taps.ToString();
        progressBar.fillAmount = taps / (float)targetTaps;
    }

    private void SpawnKey()
    {
        Vector2 clickPosition;

        randomKey = Random.Range(0, keys.Length);
        keyToSpawn = new GameObject("key", typeof(SpriteRenderer));
        keyToSpawn.GetComponent<SpriteRenderer>().sprite = keys[randomKey];
        clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        keyToSpawn.transform.position = clickPosition;
    }
}

    
