using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsActiveWith : MonoBehaviour
{
    public List<MyScreen> ActiveOnList = new List<MyScreen>();
    public GameObject ActivableObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ActivableObject.SetActive(false);
        foreach (MyScreen screen in ActiveOnList)
        {
            if(SingletonManager.Singleton.screenManager.current_screen == screen)
            {
                ActivableObject.SetActive(true);
            }
        }
    }
}
