using UnityEngine;

public class Celular : ObjetoSimple
{
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    } 
}
