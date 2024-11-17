using UnityEngine;

public class Cargador : ObjetoSimple
{
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
    }
}

