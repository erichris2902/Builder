using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LenguageManager : MonoBehaviour
{
    public Dictionary<string, string> TraductionDict = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Awake()
    {
        TraductionDict.Add("ESCANEAR", "SCAN");
        TraductionDict.Add("TUTORIAL", "TUTORIAL");
        TraductionDict.Add("AJUSTES", "SETTINGS");
        TraductionDict.Add("ACERCA DE", "ABOUT US");
        TraductionDict.Add("SONIDO", "SOUND");
        TraductionDict.Add("LEER CODIGO", "SCAN TARGET");
        TraductionDict.Add("Idioma", "Language");
        TraductionDict.Add("Sonido", "Sound");
        TraductionDict.Add("Posiciona tu camara sobre el tag", "Position your camera over the tag");
        TraductionDict.Add("Bienvenido a Hendrickson Builder, escanea las tarjetas Hendrickson para conocer mas de nuestros productos.", "Welcome to Hendrickson Builder, scan the Hendrickson cards to learn more about our products.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
