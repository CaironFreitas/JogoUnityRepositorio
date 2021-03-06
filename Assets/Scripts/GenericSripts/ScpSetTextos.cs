﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScpSetTextos : MonoBehaviour
{
    public int piLanguageGroup;
    public int piLanguageCode;

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

        switch (piLanguageGroup)
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
            case 4:
                metSetCombatButtonName();
                break;
            case 5:
                metSetEventTitleOptions();
                break;
            case 6:
                metSetEventWindowText();
                break;
            case 7:
                metSetHealthWindowText();
                break;
            case 8:
                metSetMoveName();
                break;
        }
    }

    private void metSetTexto(string partxTextoPortugues, string partxTextoIngles)
    {
        if (cbLinguaPortugues) { ctxTexto.text = partxTextoPortugues; }
        if (cbLinguaIngles) { ctxTexto.text = partxTextoIngles; }
    }

    private void metNomeiaBotoes()
    {
        //-- Group 1
        switch (piLanguageCode)
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

    private void metNomeiaJanelaNovoJogo() 
    {
        //-- Group 2
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Nome", "Name");
                break;
            case 2:
                metSetTexto("Digite seu nome...", "Type your name...");
                break;
            case 3:
                metSetTexto("Pontos de habilidade", "Skill Points");
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
                metSetTexto("Atletismo", "Athletics");
                break;
            case 8:
                metSetTexto("INFORMAÇÕES PESSOAIS", "PERSONAL DATA");
                break;
            case 9:
                metSetTexto("Furtividade", "Sneak");
                break;
        }
    }

    private void metNomeiaOpcoes()
    {
        //-- Group 3
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Idioma", "Language");
                break;
            case 2:
                metSetTexto("Preferências", "Preferences");
                break;
            case 3:
                metSetTexto("Salvar", "Save");
                break;
        }
    }

    private void metSetCombatButtonName()
    {
        //-- Group 4
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Ataque desarmado", "Unarmed attack");
                break;
            case 2:
                metSetTexto("Fugir", "Flee");
                break;
            case 3:
                metSetTexto("Esconder", "Hide");
                break;

        }
    }

    private void metSetEventTitleOptions()
    {
        //-- Group 5
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Combate", "Combat");
                break;
            case 2:
                metSetTexto("Dialogo", "Dialogue");
                break;
        }
    }

    private void metSetEventWindowText()
    {
        //-- Group 6
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Você", "You");
                break;
            case 2:
                metSetTexto("Local", "Place");
                break;
            case 3:
                metSetTexto("Condições", "Conditions");
                break;
            case 4:
                metSetTexto("Possíveis ações", "Possible actions");
                break;
            case 5:
                metSetTexto("Registros", "Log");
                break;
        }
    }

    private void metSetHealthWindowText()
    {
        //-- Group 7
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Saúde", "Health");
                break;
            case 2:
                switch (StaticPersonagem.pfHealth)
                {
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfNearDeath):
                        metSetTexto("Status geral do corpo \n <color=#FF2D00>- A beira da morte</color>", "Overall Body Status \n  <color=#FF2D00>- Near death</color> \n");
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfSeverelyInjured):
                        metSetTexto("Status geral do corpo \n <color=#FFAE00>- Gravemente ferido</color>", "Overall Body Status \n <color=#FFAE00>- Severely injured</color> \n");
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfInjured):
                        metSetTexto("Status geral do corpo \n <color=#FFE000>- Ferido</color>", "Overall Body Status \n <color=#FFE000>- Injured</color> \n");
                        break;
                    case float lfHealth when (lfHealth <= staticGameBusinessLogic.pfSlightlyInjured):
                        metSetTexto("Status geral do corpo \n <color=#E4FF00>- Levemente ferido</color>", "Overall Body Status \n <color=#E4FF00>- Slightly injured</color> \n");
                        break;
                    case float lfHealth when (lfHealth <= 100):
                        metSetTexto("Status geral do corpo \n <color=#6ABD01>- Ileso</color>", "Overall Body Status \n <color=#6ABD01>- Unhurt</color> \n");
                        break;
                }

                break;
            case 3:
                metSetTexto("Status das partes do corpo", "Body parts status");
                break;
        }
    }

    private void metSetMoveName()
    {
        //-- Group 8
        switch (piLanguageCode)
        {
            case 1:
                metSetTexto("Avançar furtivamente", "Sneak ahead");
                break;
            case 2:
                metSetTexto("Avançar caminhando", "Walk foward");
                break;
            case 3:
                metSetTexto("Avançar correndo", "Run foward");
                break;
        }
    }
}
