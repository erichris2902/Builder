using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayController : MonoBehaviour
{
    public List<GameObject> activeOn;
    public GameObject panel;
    public bool isActive;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void FixedUpdate()
    {
        isActive = false;
        for(int i = 0; i < activeOn.Count; i++)
        {
            if (activeOn[i].activeSelf)
            {
                isActive = true;
            }
        }

        if (isActive)
        {
            panel.SetActive(false);
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
