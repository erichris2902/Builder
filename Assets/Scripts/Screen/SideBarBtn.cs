using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideBarBtn : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(delegate {
            SingletonManager.Singleton.screenManager.ShowPopup(Popup.SIDEBAR);
        });
    }
}
