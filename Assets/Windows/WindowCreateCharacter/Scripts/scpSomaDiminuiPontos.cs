using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpSomaDiminuiPontos : MonoBehaviour
{
    public void Soma()
    {
        if (StaticPontos.plSkillPoints > 0)
        {
            switch (this.transform.parent.gameObject.name)
            {
                case "TxtCombateCorpo":
                    StaticPontos.plMelee++;
                    break;

                case "TxtCombateDistancia":
                    StaticPontos.plRange++;
                    break;

                case "TxtResistencia":
                    StaticPontos.plAthletics++;
                    break;
                case "TxtSneak":
                    StaticPontos.plSneak++;
                    break;
            }

            StaticPontos.plSkillPoints--;
        }
    }

    public void Diminui()
    {
        switch (this.transform.parent.gameObject.name)
        {
            case "TxtCombateCorpo":
                if (StaticPontos.plMelee > 1)
                {
                    StaticPontos.plMelee--;
                    StaticPontos.plSkillPoints++;
                }
                break;

            case "TxtCombateDistancia":
                if (StaticPontos.plRange > 1)
                {
                    StaticPontos.plRange--;
                    StaticPontos.plSkillPoints++;
                }
                break;

            case "TxtResistencia":
                if (StaticPontos.plAthletics > 1)
                {
                    StaticPontos.plAthletics--;
                    StaticPontos.plSkillPoints++;
                }
                break;
            case "TxtSneak":
                if (StaticPontos.plSneak > 1)
                {
                    StaticPontos.plSneak--;
                    StaticPontos.plSkillPoints++;
                }
                break;
        }
    }
}
