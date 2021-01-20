using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpSetTextos : MonoBehaviour
{
    public int ciTipoTexto;
    public int ciDescricaoTexto;

    private bool cbLinguaPortugues;
    private bool cbLinguaIngles;

    private Text ctxTexto;

    private void FixedUpdate()
    {
        metInicializa();
    }

    public void metInicializa()
    {
        ctxTexto = this.GetComponent<Text>();

        cbLinguaPortugues = (PlayerPrefs.GetString("Idioma") == "Portugues");
        cbLinguaIngles = (PlayerPrefs.GetString("Idioma") == "English");

        switch (ciTipoTexto)
        {
            case 1:
                metNomeiaBotoes();
                break;
            case 2:
                metNomeiaJanelaNovoJogo();
                break;
            case 3:
                metNomeiaOpcoes();
                break;
        }
    }

    private void metSetTexto(string partxTextoPortugues, string partxTextoIngles)
    {
        if (cbLinguaPortugues) { ctxTexto.text = partxTextoPortugues; }
        if (cbLinguaIngles) { ctxTexto.text = partxTextoIngles; }
    }

    //-- 1
    private void metNomeiaBotoes()
    {
        switch (ciDescricaoTexto)
        {
            case 1:
                metSetTexto("Continuar", "Continue");
                break;
            case 2:
                metSetTexto("Novo jogo", "New game");
                break;
            case 3:
                metSetTexto("Opções", "Options");
                break;
            case 4:
                metSetTexto("Sair", "Quit");
                break;
        }
    }

    //-- 2
    private void metNomeiaJanelaNovoJogo() 
    {
        switch (ciDescricaoTexto)
        {
            case 1:
                metSetTexto("Nome", "Name");
                break;
            case 2:
                metSetTexto("Digite seu nome...", "Type your name...");
                break;
            case 3:
                metSetTexto("PONTOS DE HABILIDADE", "SKILL POINTS");
                break;
            case 4:
                metSetTexto("Começar", "Start");
                break;
            case 5:
                metSetTexto("Combate corpo a corpo", "Melee combat");
                break;
            case 6:
                metSetTexto("Combate a distância", "Range combat");
                break;
            case 7:
                metSetTexto("Resistência", "Endurance");
                break;
            case 8:
                metSetTexto("INFORMAÇÕES PESSOAIS", "PERSONAL DATA");
                break;
        }
    }

    //-- 3 Preferencias 
    private void metNomeiaOpcoes()
    {
        switch (ciDescricaoTexto)
        {
            case 1:
                metSetTexto("Idioma", "Language");
                break;
            case 2:
                metSetTexto("PREFERÊNCIAS", "PREFERENCES");
                break;
            case 3:
                metSetTexto("Salvar", "Save");
                break;
        }
    }
}
