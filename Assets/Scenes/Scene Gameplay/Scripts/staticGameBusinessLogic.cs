using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticGameBusinessLogic
{
    //-- Character creation
    public static long plStartSkillPoints = 15;

    //-- Overall and body parts damage logic
    public static float pfSlightlyInjured = 99;
    public static float pfInjured = 75;
    public static float pfSeverelyInjured = 50;
    public static float pfNearDeath = 25;

    //-- Colors
    public static string psRedColorBad = "<color=#8A0505>";
    public static string psGreenColorGood = "<color=#00810C>";
}
