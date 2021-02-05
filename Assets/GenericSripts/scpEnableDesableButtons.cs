using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpEnableDesableButtons : MonoBehaviour
{
    public string psTag;

    private void Update()
    {
        this.GetComponent<Button>().interactable = (GameObject.FindGameObjectsWithTag(psTag).GetUpperBound(0) == -1);
    }
}
