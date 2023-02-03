using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopPanel : MonoBehaviour
{
    public Button MenuBtn;
    public Button HomeBtn;

    // Start is called before the first frame update
    void Start()
    {
        MenuBtn.onClick.AddListener(delegate {
            SingletonManager.Singleton.screenManager.ShowPopup(Popup.SIDEBAR);
        });
        HomeBtn.onClick.AddListener(delegate {
            SingletonManager.Singleton.screenManager.ChangeScreen(MyScreen.AR);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
