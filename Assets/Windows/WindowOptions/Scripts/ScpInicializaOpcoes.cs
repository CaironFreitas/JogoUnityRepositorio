using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpInicializaOpcoes : MonoBehaviour
{
    public Dropdown cdpIdioma;

    private void Start()
    {
        switch (PlayerPrefs.GetString("Idioma"))
        {
            case "Portugues":
                cdpIdioma.value = 1;
                break;
            case "English":
                cdpIdioma.value = 0;
                break;
        }
    }
}
