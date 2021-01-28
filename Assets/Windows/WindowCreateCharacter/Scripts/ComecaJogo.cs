using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComecaJogo : MonoBehaviour
{
    public void IniciaJogo()
    {
        StaticPersonagem.plMelee = StaticPontos.plMelee;
        StaticPersonagem.plRange = StaticPontos.plRange;
        StaticPersonagem.plAthletics = StaticPontos.plAthletics;
        StaticPersonagem.plSneak = StaticPontos.plSneak;

        SceneManager.LoadScene("Gameplay");
    }
}
