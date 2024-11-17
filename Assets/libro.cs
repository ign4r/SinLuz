using System;
using UnityEngine;
using UnityEngine.UI;

public class Libro : ObjetoSimple
{

    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    }

  
}
