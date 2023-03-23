using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
    }

    public void OpenClosePanel()
    {
        panel.SetActive(!panel.activeSelf);
        Debug.Log("Opened panel " + panel.name);
    }
}

