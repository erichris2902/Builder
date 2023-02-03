using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnTrack : MonoBehaviour
{
    public GameObject ar_object;
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isActive)
        {
            ar_object.SetActive(true);
        }
    }

    private void OnDisable()
    {
        ar_object.SetActive(false);
    }
}
