using UnityEngine;

public class ScpCriarJanela : MonoBehaviour
{
    public GameObject cgoJanela;
    public Canvas ccsMainCanvas;

    public void metCriaJanela()
    {
        GameObject CloneCgoJanela = Instantiate(cgoJanela, ccsMainCanvas.transform);
    }
}
