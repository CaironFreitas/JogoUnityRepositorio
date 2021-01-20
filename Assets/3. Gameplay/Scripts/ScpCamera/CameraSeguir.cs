using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{

    void FixedUpdate()
    {
        Vector3 V3Jogador = new Vector3(StaticPersonagem.ObjJogador.transform.position.x, StaticPersonagem.ObjJogador.transform.position.y, -3f);
        Vector3 V3Camera = new Vector3(transform.position.x, transform.position.y, -3f);
        transform.position = Vector3.Lerp(V3Camera, V3Jogador, 0.05f);
    }
}
