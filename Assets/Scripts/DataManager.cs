using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class DataManager : MonoBehaviour
{
    public bool isSound = false;
    public idiomas actualLanguage = idiomas.SPANISH;
}

public enum idiomas
{
    SPANISH,
    ENGLISH
}