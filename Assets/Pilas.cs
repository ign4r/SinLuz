using UnityEngine;

public class Pilas : ObjetoSimple
{
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    }
}
