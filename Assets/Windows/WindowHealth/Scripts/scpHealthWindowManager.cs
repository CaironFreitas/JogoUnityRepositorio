using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpHealthWindowManager : MonoBehaviour
{
    public GameObject ptxtHealthInfo;
    public GameObject pobjHealthContent;

    private GameObject pobjHeadtHealthInfo;
    private GameObject pobjNecktHealthInfo;
    private GameObject pobjChestHealthInfo;
    private GameObject pobjLeftShoulderHealthInfo;
    private GameObject pobjRightShoulderHealthInfo;
    private GameObject pobjLeftArmHealthInfo;
    private GameObject pobjRightArmHealthInfo;
    private GameObject pobjLeftForearmHealthInfo;
    private GameObject pobjRightForearmHealthInfo;
    private GameObject pobjLeftHandHealthInfo;
    private GameObject pobjRightHandHealthInfo;
    private GameObject pobjRightThighHealthInfo;
    private GameObject pobjLeftThighHealthInfo;
    private GameObject pobjLeftShinHealthInfo;
    private GameObject pobjRightShinHealthInfo;
    private GameObject pobjLeftFeetHealthInfo;
    private GameObject pobjRightFeetHealthInfo;

    private scpSetRichText pscpSetRichText;

    public void Start()
    {
        pscpSetRichText = this.gameObject.AddComponent(typeof(scpSetRichText)) as scpSetRichText;
    }

    void Update()
    {
        metCreateBodyPartInfo(StaticPersonagem.pfHealthHead, ref pobjHeadtHealthInfo, 5, 1);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthNeck, ref pobjNecktHealthInfo, 5, 2);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthChest, ref pobjChestHealthInfo, 5, 3);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthLeftShoulder, ref pobjLeftShoulderHealthInfo, 5, 4);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthRightShoulder, ref pobjRightShoulderHealthInfo, 5, 5);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthLeftArm, ref pobjLeftArmHealthInfo, 5, 6);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthRightArm, ref pobjRightArmHealthInfo, 5, 7);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthForearmLeft, ref pobjLeftForearmHealthInfo, 5, 8);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthForearmRight, ref pobjRightForearmHealthInfo, 5, 9);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthHandLeft, ref pobjLeftHandHealthInfo, 5, 10);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthHandRight, ref pobjRightHandHealthInfo, 5, 11);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthThighLeft, ref pobjLeftThighHealthInfo, 5, 13);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthThighRight, ref pobjRightThighHealthInfo, 5, 12);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthShinLeft, ref pobjLeftShinHealthInfo, 5, 14);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthShinRight, ref pobjRightShinHealthInfo, 5, 15);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthFeetLeft, ref pobjLeftFeetHealthInfo, 5, 16);
        metCreateBodyPartInfo(StaticPersonagem.pfHealthFeetRight, ref pobjRightFeetHealthInfo, 5, 17);
    }

    private void metCreateBodyPartInfo(float parfBodyPartHP, ref GameObject parobjBodyPart, int pariRichTextGroup, int pariRichTextCode)
    {
        if (parfBodyPartHP < 100)
        {
            if (parobjBodyPart == null)
            {
                parobjBodyPart = Instantiate(ptxtHealthInfo, pobjHealthContent.GetComponent<RectTransform>().transform);
            } else
            {
                string lsBodyPart = pscpSetRichText.metFindText(pariRichTextGroup, pariRichTextCode);
                string lsInjury = "";

                switch (parfBodyPartHP)
                {
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfVerySeriousInjury):
                        lsInjury = pscpSetRichText.metFindText(6, 6);
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfSeriousInjury):
                        lsInjury = pscpSetRichText.metFindText(6, 5);
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfInjury):
                        lsInjury = pscpSetRichText.metFindText(6, 4);
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfModerateInjury):
                        lsInjury = pscpSetRichText.metFindText(6, 3);
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfSuperficialInjury):
                        lsInjury = pscpSetRichText.metFindText(6, 2);
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfScratches):
                        lsInjury = pscpSetRichText.metFindText(6, 1);
                        break;
                }

                Text ltxtPartText = parobjBodyPart.GetComponent<Text>();
                ltxtPartText.text = lsBodyPart + "\n - " + lsInjury;
            }
        } else
        {
            Destroy(parobjBodyPart);
        }
    }
}
