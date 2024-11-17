using System;
using UnityEngine;

public class Libro : ObjetoSimple
{
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    }
}
