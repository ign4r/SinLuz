using System.Collections;
using UnityEngine;

public class Mate : ObjetoSimple
{
    [SerializeField] GameObject tomandoMate;
    [SerializeField] float segundosDeEspera;

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        tomandoMate.SetActive(true);
        Invoke("resetMate",segundosDeEspera);   
    }

    private void resetMate()
    {
       tomandoMate.SetActive(false);
       gameObject.SetActive(true);
    }

}
