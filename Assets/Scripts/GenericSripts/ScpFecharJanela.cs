using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScpFecharJanela : MonoBehaviour
{
    public GameObject cobjJanela;
    public void metFecharJanela()
    {
        Destroy(cobjJanela);
    }
}