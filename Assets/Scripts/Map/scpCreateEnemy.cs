using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scpCreateEnemy : MonoBehaviour
{
    public GameObject pobjDefaultEnemy;

    // Update is called once per frame
    void Update()
    {
        int liEnemyCount = GameObject.FindGameObjectsWithTag("EnemyDefault").Length;

        if (liEnemyCount < 2)
        {
            if (staticScpMapProperties.psbMapaCriado)
            {
                //-- Create enemy on a random tile
                int liHeight = Random.Range(0, staticScpMapProperties.psiMapHeight);
                int liWeight = Random.Range(0, staticScpMapProperties.psiMapWeight);

                string lsTileName = liHeight + "," + liWeight;

                GameObject lobjTileRandom = GameObject.Find(lsTileName);

                if (lobjTileRandom != StaticPersonagem.ObjTileAtual)
                {
                    GameObject CloneDefaultEnemy = Instantiate(pobjDefaultEnemy);

                    CloneDefaultEnemy.transform.position = lobjTileRandom.transform.position;
                    scpEnemyInfo lscpEnemyInfo = CloneDefaultEnemy.GetComponent<scpEnemyInfo>();
                    lscpEnemyInfo.pobjCurrentEnemyTile = lobjTileRandom;
                }
            }
        }
    }
}
