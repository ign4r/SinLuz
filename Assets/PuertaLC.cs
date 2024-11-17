using UnityEngine;

public class PuertaLC : ObjetoSimple
{
    [SerializeField] GameObject camMain;
    [SerializeField] GameObject camDireccion;
    private void OnMouseDown()
    {
        camMain.SetActive(false);
        camDireccion.SetActive(true);
    }
}

