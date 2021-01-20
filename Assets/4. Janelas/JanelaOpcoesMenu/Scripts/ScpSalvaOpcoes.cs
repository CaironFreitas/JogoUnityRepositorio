using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpSalvaOpcoes : MonoBehaviour
{
    public Text ctxTxtIdioma;
    public void metSalvaOpcoes()
    {
        switch (ctxTxtIdioma.text)
        {
            case "Português":
                PlayerPrefs.SetString("Idioma", "Portugues");
                break;

            case "English":
                PlayerPrefs.SetString("Idioma", "English");
                break;
        }
    }
}
