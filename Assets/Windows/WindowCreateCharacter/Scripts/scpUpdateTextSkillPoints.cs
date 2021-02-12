using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpUpdateTextSkillPoints : MonoBehaviour
{
    public scpAddDecPoints pscpAddDecPoints;
    public long plSkillCode;

    public void FixedUpdate()
    {
        switch (plSkillCode)
        {
            case 1:
                this.GetComponent<Text>().text = pscpAddDecPoints.plSkillPoints.ToString();
                break;
            case 2:
                this.GetComponent<Text>().text = pscpAddDecPoints.plMeleePoints.ToString();
                break;
            case 3:
                this.GetComponent<Text>().text = pscpAddDecPoints.plRangePoints.ToString();
                break;
            case 4:
                this.GetComponent<Text>().text = pscpAddDecPoints.plAthleticsPoints.ToString();
                break;
            case 5:
                this.GetComponent<Text>().text = pscpAddDecPoints.plSneakPoints.ToString();
                break;
        }
    }
}
