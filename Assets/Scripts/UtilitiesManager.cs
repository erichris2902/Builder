using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.ARFoundation;
using UnityEngine.SceneManagement;

public class UtilitiesManager : MonoBehaviour
{
    public Color main_enable;
    public Color main_disable;
    public int target_fps = 30;

    public TextMeshProUGUI FPSTxt;

    public Camera ar_camara;

    public Button shutterBtn;


    public void Start()
    {
        Application.targetFrameRate = target_fps;

        
    }


    public void closeARScene(string scene_name_ar)
    {
        StartCoroutine(closeARSceneCoroutine(scene_name_ar));
    }

    public IEnumerator closeARSceneCoroutine(string scene_name_ar)
    {
        yield return new WaitForSeconds(1.2f);
        if (SceneManager.sceneCount >= 2)
            SceneManager.UnloadSceneAsync(scene_name_ar);
        print("acabo chingon");
    }

}
