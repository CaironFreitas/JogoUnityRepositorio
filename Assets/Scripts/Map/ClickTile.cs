using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickTile : MonoBehaviour
{
    public GameObject ObjJogador;

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            metMovimentaPersonagemClickTile();
        }
    }
    private void metMovimentaPersonagemClickTile()
    {
        if (StaticPersonagem.ObjTileAtual.name != this.name)
        {
            PropriedadesTile ScpPropriedades = StaticPersonagem.ObjTileAtual.GetComponent<PropriedadesTile>();

            int PosX = ScpPropriedades.PosX;
            int PosY = ScpPropriedades.PosY;

            bool lbTileAptoParaMovimentacao = false;

            if (PosX % 2 == 0)
            {
                if (this.name == (PosX - 1).ToString() + "," + (PosY).ToString() ||
                    this.name == (PosX - 1).ToString() + "," + (PosY - 1).ToString() ||
                    this.name == (PosX).ToString() + "," + (PosY + 1).ToString() ||
                    this.name == (PosX).ToString() + "," + (PosY - 1).ToString() ||
                    this.name == (PosX + 1).ToString() + "," + (PosY).ToString() ||
                    this.name == (PosX + 1).ToString() + "," + (PosY - 1).ToString())
                {
                    lbTileAptoParaMovimentacao = true;
                }
            }
            else
            {
                if (this.name == (PosX - 1).ToString() + "," + (PosY + 1).ToString() ||
                    this.name == (PosX - 1).ToString() + "," + (PosY).ToString() ||
                    this.name == (PosX).ToString() + "," + (PosY + 1).ToString() ||
                    this.name == (PosX).ToString() + "," + (PosY - 1).ToString() ||
                    this.name == (PosX + 1).ToString() + "," + (PosY + 1).ToString() ||
                    this.name == (PosX + 1).ToString() + "," + (PosY).ToString())
                {
                    lbTileAptoParaMovimentacao = true;
                }
            }

            if (lbTileAptoParaMovimentacao)
            {
                StaticPersonagem.ObjTileAtual = this.gameObject;
                ObjJogador.transform.position = this.transform.position;
            }
        }
    }
}
