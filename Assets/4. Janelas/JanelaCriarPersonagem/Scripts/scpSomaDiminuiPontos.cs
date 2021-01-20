using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpSomaDiminuiPontos : MonoBehaviour
{
    public void Soma()
    {
        if (StaticPontos.llPontosHabilidade > 0)
        {
            switch (this.transform.parent.gameObject.name)
            {
                case "TxtCombateCorpo":
                    StaticPontos.llPontosCorpoCorpo++;
                    break;

                case "TxtCombateDistancia":
                    StaticPontos.llPontosDistancia++;
                    break;

                case "TxtResistencia":
                    StaticPontos.llPontosResistencia++;
                    break;
            }

            StaticPontos.llPontosHabilidade--;
        }
    }

    public void Diminui()
    {
        switch (this.transform.parent.gameObject.name)
        {
            case "TxtCombateCorpo":
                if (StaticPontos.llPontosCorpoCorpo > 1)
                {
                    StaticPontos.llPontosCorpoCorpo--;
                    StaticPontos.llPontosHabilidade++;
                }
                break;

            case "TxtCombateDistancia":
                if (StaticPontos.llPontosDistancia > 1)
                {
                    StaticPontos.llPontosDistancia--;
                    StaticPontos.llPontosHabilidade++;
                }
                break;

            case "TxtResistencia":
                if (StaticPontos.llPontosResistencia > 1)
                {
                    StaticPontos.llPontosResistencia--;
                    StaticPontos.llPontosHabilidade++;
                }
                break;
        }
    }
}
