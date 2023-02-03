using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARController : MonoBehaviour
{
    public GameObject Ar_Go;

    private void OnEnable()
    {
        if (!SingletonManager.Singleton) return;
        if (SingletonManager.Singleton.screenManager.current_screen != MyScreen.AR) return;
        Ar_Go.SetActive(true);
    }

    private void OnDisable()
    {

        Ar_Go.SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
