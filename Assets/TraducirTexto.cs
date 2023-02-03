using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TraducirTexto : MonoBehaviour
{
    public string keyword;
    public TextMeshProUGUI TMP;
    // Start is called before the first frame update
    void Start()
    {
        TMP = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(SingletonManager.Singleton.dataManager.actualLanguage == idiomas.SPANISH)
        {
            TMP.text = keyword;
        }

        if (SingletonManager.Singleton.dataManager.actualLanguage == idiomas.ENGLISH)
        {
            TMP.text = SingletonManager.Singleton.lenguageManager.TraductionDict[keyword];
        }
    }
}
