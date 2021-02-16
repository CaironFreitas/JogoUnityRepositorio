using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpCreateCentralizeWindow : MonoBehaviour
{
    public GameObject pobjJanela;
    public Canvas pcsMainCanvas;

    private GameObject cgoCreatedWindow;

    public void metCriaJanela()
    {
        if (cgoCreatedWindow != null)
        {
            cgoCreatedWindow.transform.GetChild(0).transform.localPosition = new Vector3(0, 0, 0);
        } else
        {
            GameObject CloneCgoJanela = Instantiate(pobjJanela, pcsMainCanvas.transform);
            cgoCreatedWindow = CloneCgoJanela;
            cgoCreatedWindow.transform.GetChild(0).transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}
