using UnityEngine;

public class Celular : ObjetoSimple
{
    private bool isCharged;

    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    } 

    public void ChangeState()
    {
        if (isCharged)
        {
            //TODO: CAMBIAR SPRITE
        }
        else
        {
            //TODO: CAMBIAR SPRITE
        }
    }
}
