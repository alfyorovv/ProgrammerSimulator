using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageController : MonoBehaviour
{
    [SerializeField] GameObject description;

    private void Start()
    {
        description.SetActive(false);
    }

    public void OpenCloseDescription()
    {
        description.SetActive(!description.activeSelf);
    }
}
