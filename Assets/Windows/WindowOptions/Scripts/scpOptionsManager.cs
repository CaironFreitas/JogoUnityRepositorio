using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpOptionsManager : MonoBehaviour
{
    public Dropdown pddLanguage;

    private void Start()
    {
        switch (PlayerPrefs.GetString("Idioma"))
        {
            case "English":
                pddLanguage.value = 0;
                break;
            case "Portugues":
                pddLanguage.value = 1;
                break;
        }
    }

    public void metSaveOptions()
    {
        switch (pddLanguage.value)
        {
            case 0:
                PlayerPrefs.SetString("Idioma", "English"); 
                break;

            case 1:
                PlayerPrefs.SetString("Idioma", "Portugues");
                break;
        }
    }
}
