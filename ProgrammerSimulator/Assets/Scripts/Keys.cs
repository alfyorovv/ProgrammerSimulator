using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    private float speed = 5f;
    private int randomDirection;
    private int randomKey;

    private GameObject keyToSpawn;
    private Vector2 direction;
    [SerializeField] private Sprite[] keys;

    private void Start()
    {
        randomDirection = Random.Range(0, 3);
    }

  private void Update()
    {
        ChooseRandomDirection();
        gameObject.transform.Translate(direction * speed * Time.deltaTime); 

    }

    public void SpawnKey()
    {
        Vector2 clickPosition;

        randomKey = Random.Range(0, keys.Length);
        keyToSpawn = new GameObject("key", typeof(SpriteRenderer));
        keyToSpawn.AddComponent<Keys>();
        keyToSpawn.GetComponent<SpriteRenderer>().sprite = keys[randomKey];
        clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        keyToSpawn.transform.position = clickPosition;
        keyToSpawn.GetComponent<SpriteRenderer>().sortingOrder = 5;
    }

    private void ChooseRandomDirection()
    {
        switch (randomDirection)
        {
            case 0:
                direction = Vector2.right;
                break;
            case 1:
                direction = Vector2.down;
                break;
            case 2:
                direction = -Vector2.right;
                break;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject); 
    }

}
