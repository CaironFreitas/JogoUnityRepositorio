using UnityEngine;

public class HexTileGenerator : MonoBehaviour
{
    public GameObject ObjTileHexagonal;
    public GameObject ObjJogador;
    public Camera MainCamera;

    int MapaLargura = 8;
    int MapaAltura = 8;

    float TileAfastamentoX = 2.741f;
    float TileAfastamentoY = 1.82f;

    private GameObject CloneObjPersonagem;

    void Start()
    {
        CloneObjPersonagem = Instantiate(ObjJogador);
        StaticPersonagem.ObjJogador = CloneObjPersonagem;
        GerarMapa();
    }

    void GerarMapa()
    {
        for (int x = 0; x <= MapaLargura; x++)
        {
            for (int y = 0; y <= MapaAltura; y++)
            {
                GameObject CloneObjTileHexagonal = Instantiate(ObjTileHexagonal);
                SetVariaveisTile(CloneObjTileHexagonal);

                if (x % 2 == 0)
                {
                    CloneObjTileHexagonal.transform.position = new Vector3(x * TileAfastamentoX, y * TileAfastamentoY);
                }
                else
                {
                    CloneObjTileHexagonal.transform.position = new Vector3(x * TileAfastamentoX, y * TileAfastamentoY + 0.9f);
                }

                SetTileInformacao(CloneObjTileHexagonal, x, y);
                InicializaConformeTiles(x, y, CloneObjTileHexagonal);
            }
        }
    }

    void SetTileInformacao(GameObject OjbTile, int x, int y)
    {
        OjbTile.transform.parent = transform;
        OjbTile.name = x.ToString() + "," + y.ToString();
        OjbTile.GetComponent<PropriedadesTile>().PosX = x;
        OjbTile.GetComponent<PropriedadesTile>().PosY = y;
    }

    void InicializaConformeTiles(int x, int y, GameObject ObjTile)
    {
        if (x == 1 & y == 1)
        {
            SpawnPersonagem(ObjTile);
            StaticPersonagem.ObjTileAtual = ObjTile;
        }
    }

    void SpawnPersonagem(GameObject objTile)
    {
        StaticPersonagem.ObjJogador.transform.position = objTile.transform.position;
    }

    void SetVariaveisTile(GameObject objTile)
    {
        objTile.GetComponent<ClickTile>().ObjJogador = StaticPersonagem.ObjJogador;
    }
}
