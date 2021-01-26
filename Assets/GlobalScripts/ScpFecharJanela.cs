using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScpFecharJanela : MonoBehaviour
{
    public GameObject cgoJanela;
    public void metFecharJanela()
    {
        Destroy(cgoJanela);
    }
}