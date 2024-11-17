using UnityEngine;

public class Llave : ObjetoSimple
{
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    }

}
