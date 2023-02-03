using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Button SpanishBtn;
    public Button EnglishBtn;
    public Button SoundBtn;

    public GameObject isOnSound;
    public GameObject isOffSound;
    public GameObject isSpanish;
    public GameObject isEnglish;

    // Start is called before the first frame update
    void Start()
    {
        SpanishBtn.onClick.AddListener(delegate {
            SingletonManager.Singleton.dataManager.actualLanguage = idiomas.SPANISH;
        });

        EnglishBtn.onClick.AddListener(delegate {
            SingletonManager.Singleton.dataManager.actualLanguage = idiomas.ENGLISH;
        });

        SoundBtn.onClick.AddListener(delegate {
            SingletonManager.Singleton.dataManager.isSound = !SingletonManager.Singleton.dataManager.isSound;
        });
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isSpanish.SetActive(false);
        isEnglish.SetActive(false);
        isOnSound.SetActive(false);
        isOffSound.SetActive(true);
        if (SingletonManager.Singleton.dataManager.actualLanguage == idiomas.SPANISH)
        {
            isSpanish.SetActive(true);
        }

        if (SingletonManager.Singleton.dataManager.actualLanguage == idiomas.ENGLISH)
        {
            isEnglish.SetActive(true);
        }

        if (SingletonManager.Singleton.dataManager.isSound == true)
        {
            isOnSound.SetActive(true);
            isOffSound.SetActive(false);
        }
    }
}
