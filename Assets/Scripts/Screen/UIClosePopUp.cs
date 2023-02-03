using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIClosePopUp : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(delegate {
            SingletonManager.Singleton.screenManager.ShowPopup(Popup.NONE);
        });
    }
}
