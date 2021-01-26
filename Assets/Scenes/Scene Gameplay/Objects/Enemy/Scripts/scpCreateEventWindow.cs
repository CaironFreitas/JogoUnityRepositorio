using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpCreateEventWindow : MonoBehaviour
{
    public GameObject pobjEventWindow;
    
    private GameObject cobjMainCanvas;

    private void Start()
    {
        cobjMainCanvas = GameObject.Find("Canvas");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (StaticPersonagem.ObjJogador.transform.position == this.transform.position)
        {
            if (GameObject.FindGameObjectsWithTag("WindowEvent").GetUpperBound(0) < 0)
            {
                GameObject CloneCgoJanela = Instantiate(pobjEventWindow, cobjMainCanvas.transform);
            }
        }
    }
}
