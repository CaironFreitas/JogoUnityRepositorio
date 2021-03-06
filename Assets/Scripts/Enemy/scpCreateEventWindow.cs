﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpCreateEventWindow : MonoBehaviour
{
    public GameObject pobjEventWindow;
    public scpEnemyInfo pscpEnemyInfo;

    private GameObject cobjMainCanvas;

    private void Start()
    {
        cobjMainCanvas = GameObject.Find("Canvas");
        pscpEnemyInfo = this.GetComponent<scpEnemyInfo>();
    }

    void FixedUpdate()
    {
        if (StaticPersonagem.ObjTileAtual == pscpEnemyInfo.pobjCurrentEnemyTile)
        {
            if (GameObject.FindGameObjectsWithTag("WindowEvent").GetUpperBound(0) < 0)
            {
                GameObject CloneCgoJanela = Instantiate(pobjEventWindow, cobjMainCanvas.transform);
                staticWindowEvent.pscpEnemyInfo = pscpEnemyInfo;
            }
        }
    }
}
