using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpWindowEventManager : MonoBehaviour
{
    [Header("Window's objects")]
    public Image pobjLocalImage;
    public Image pobjPlayerImage;
    public Image pobjEnemyImage;

    [Header("Window's contents")]
    public GameObject pobjContentPlayerCondition;
    public GameObject pobjContentEnemyCondition;
    public GameObject pobjContentLocalCondition;

    [Header("Scripts")]
    public scpEnemyInfo pscpEnemyInfo;
    private scpSetRichText pscpSetRichText;

    [Header("Objects to instantiate")]
    public GameObject pobjText;

    [Header("Contents objects")]
    private Text ctxtDistance;
    private Text ctxtPlayerSpotted;

    void Start()
    {
        pscpSetRichText = this.gameObject.AddComponent(typeof(scpSetRichText)) as scpSetRichText;
        pscpEnemyInfo   = staticWindowEvent.pscpEnemyInfo;

        //-- Set Player, enemy and local image
        pobjLocalImage.sprite = StaticPersonagem.ObjTileAtual.GetComponent<SpriteRenderer>().sprite;
        pobjPlayerImage.sprite = StaticPersonagem.ObjJogador.GetComponent<SpriteRenderer>().sprite;
        pobjEnemyImage.sprite = pscpEnemyInfo.pobjEnemy.GetComponent<SpriteRenderer>().sprite;

        //-- Set Enemy conditions
        metCreateEnemyConditions();
    }

    private void FixedUpdate()
    {
        ctxtDistance.text = pscpSetRichText.metFindText(7, 1) + staticWindowEvent.plDistance + "m";

        if (staticWindowEvent.plPlayerSpotted)
        {
            ctxtPlayerSpotted.text = pscpSetRichText.metFindText(7, 2);
        }
        else
        {
            ctxtPlayerSpotted.text = pscpSetRichText.metFindText(7, 3);
        }
    }

    private long metDistanceCalculation()
    {
        long llDistanceScale = Random.Range(0, 100);

        switch (llDistanceScale)
        {
            case long llChance when (llChance <= 50):
                return staticWindowEvent.plDistance = Random.Range(15, 25);
            case long llChance when (llChance <= 95):
                return staticWindowEvent.plDistance = Random.Range(25, 40);
            case long llChance when (llChance <= 100):
                return staticWindowEvent.plDistance = Random.Range(5, 15);
        }

        return 20;
    }

    private void metPlayerSneakApproachCalculation()
    {
        long llDefaultChance = 35;
        long llSkillDiff = StaticPersonagem.plSneak * 3;
        long llSneakApproachChance = llDefaultChance + llSkillDiff;

        long llChance = Random.Range(0, 100);

        staticWindowEvent.plPlayerSpotted = (llChance <= llSneakApproachChance);

        Debug.Log(llChance + " - " + llSneakApproachChance);
    }

    private void metCreateEnemyConditions()
    {
        metDistanceCalculation();
        metPlayerSneakApproachCalculation();

        GameObject CloneOjbText = Instantiate(pobjText, pobjContentEnemyCondition.GetComponent<RectTransform>().transform);
        ctxtDistance = CloneOjbText.GetComponent<Text>();

        CloneOjbText = Instantiate(pobjText, pobjContentEnemyCondition.GetComponent<RectTransform>().transform);
        ctxtPlayerSpotted = CloneOjbText.GetComponent<Text>();
    }
}
