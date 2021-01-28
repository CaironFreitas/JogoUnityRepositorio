using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class StaticPontos
{
    public static long plStartSkillPoints = 14;
    public static long plSkillPoints;
    public static long plMelee;
    public static long plRange;
    public static long plAthletics;
    public static long plSneak;

    public static void metSetPontosIniciais()
    {
        plSkillPoints = plStartSkillPoints;
        plMelee       = 1;
        plRange       = 1;
        plAthletics   = 1;
        plSneak       = 1;
    }

}
