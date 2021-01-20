using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpInicializaMenu : MonoBehaviour
{
    void Start()
    {
        string lsIdioma = PlayerPrefs.GetString("Idioma");

        if (lsIdioma == "")
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Portuguese:
                    PlayerPrefs.SetString("Idioma", "Portugues");
                    break;

                default:
                    PlayerPrefs.SetString("Idioma", "English");
                    break;
            }
        }
    }

}
