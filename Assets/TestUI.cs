using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestUI : MonoBehaviour
{
    public static TestUI testUI;
    public GameObject touch;
    public GameObject contact;
    public TextMeshProUGUI T1;
    public TextMeshProUGUI T2;

    // Start is called before the first frame update
    void Awake()
    {
        testUI = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
