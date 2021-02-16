using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class staticGameBusinessLogic
{
    //-- Character creation
    public static long plStartSkillPoints = 15;

    //-- Overall body damage
    public static float pfSlightlyInjured = 99;
    public static float pfInjured = 75;
    public static float pfSeverelyInjured = 50;
    public static float pfNearDeath = 25;

    //-- Body parts damage
    public static float pfScratches = 99;
    public static float pfSuperficialInjury = 85;
    public static float pfModerateInjury = 75;
    public static float pfInjury = 50;
    public static float pfSeriousInjury= 25;
    public static float pfVerySeriousInjury = 2;

    //-- Body parts color
    public static string psColorScratches = "<color=#c6e000>";
    public static string psColorSuperficialInjury = "<color=#dce000>";
    public static string psColorModerateInjury = "<color=#cca300>";
    public static string psColorInjury = "<color=#c77b00>";
    public static string psColorSeriousInjury = "<color=#FF2D00>";
    public static string psColorVerySeriousInjury = "<color=#FF2D00>";

    //-- General Colors
    public static string psRedColorBad = "<color=#8A0505>";
    public static string psGreenColorGood = "<color=#00810C>";
    public static string psOrangeInformation = "<color=#9c6f00>";
}
