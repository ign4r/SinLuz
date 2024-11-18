using UnityEngine;
using UnityEngine.UI;

public class Celular : ObjetoSimple
{
    private bool isCharged;
    [SerializeField]Image imageComponent;
    [SerializeField] Sprite unCharged;
    [SerializeField] Sprite charged;
    [SerializeField] AudioSource aSource;
    

    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
    } 

    public void Charged()
    {
        isCharged = true;
        imageComponent.sprite = charged;
    }
    public void Use()
    {
        if (isCharged)
        {
            aSource.Play();
        }

    }
}
