using UnityEngine;

public class PuertaLC : ObjetoSimple
{
    [SerializeField] GameObject camMain;
    [SerializeField] GameObject camDireccion;
    [SerializeField] bool abierta;
    [SerializeField] Inventario inven;


    private void OnMouseDown()
    {
        if (inven.consultaPorNombre("Llave") || abierta)
        {
            camMain.SetActive(false);
            camDireccion.SetActive(true);
        }      
    }
}

