using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class UIPopup : MonoBehaviour
{
    public Popup popup;
    [SerializeField] UnityEvent OnActivePopup;

    private void Awake()
    {
    }

    private void Start()
    {

        //Subscribe the event for active and deactive screen
        SingletonManager.Singleton.screenManager.OnPopupShow += ActivePopup;
        SingletonManager.Singleton.screenManager.OnPopupClose += HidePopup;
        SingletonManager.Singleton.screenManager.RegisterScreen();
        SingletonManager.Singleton.screenManager.HidePopup();
    }

    //If the current scene is this one, activate it
    private void ActivePopup(Popup current_popup)
    {
        if (current_popup == popup)
        {
            this.GetComponent<RectTransform>().localPosition = Vector3.zero;
            this.gameObject.SetActive(true);
            OnActivePopup.Invoke();
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    private void HidePopup()
    {
        this.gameObject.SetActive(false);
    }


    private void OnDestroy()
    {
        //if destroyed just remove the suscribed event
        SingletonManager.Singleton.screenManager.OnPopupShow -= ActivePopup;
    }


}
