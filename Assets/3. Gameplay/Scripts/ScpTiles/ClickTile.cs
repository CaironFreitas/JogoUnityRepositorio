using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTile : MonoBehaviour
{
    public GameObject ObjJogador;

    private void OnMouseDown()
    {
        if (StaticPersonagem.ObjTileAtual.name != this.name)
        {
            PropriedadesTile ScpPropriedades = StaticPersonagem.ObjTileAtual.GetComponent<PropriedadesTile>();

            int PosX = ScpPropriedades.PosX;
            int PosY = ScpPropriedades.PosY;

            bool TileAptoParaMovimentacao = false;

            if (PosX % 2 == 0)
            {
                if (this.name == (PosX - 1).ToString() + "," + (PosY).ToString() ||
                    this.name == (PosX - 1).ToString() + "," + (PosY -1).ToString() ||
                    this.name == (PosX).ToString() + "," + (PosY + 1).ToString() ||
                    this.name == (PosX).ToString() + "," + (PosY - 1).ToString() ||
                    this.name == (PosX + 1).ToString() + "," + (PosY).ToString() ||
                    this.name == (PosX + 1).ToString() + "," + (PosY - 1).ToString())
                {
                    TileAptoParaMovimentacao = true;
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
                    TileAptoParaMovimentacao = true;
                }
            }

            if (TileAptoParaMovimentacao)
            {
                StaticPersonagem.ObjTileAtual = this.gameObject;
                ObjJogador.transform.position = this.transform.position;
            }
        }
    }
}
