using System;
using UnityEngine;

public class ObjetoSimple : MonoBehaviour
{
    public Sprite sinLuz;
    public Sprite conLuz;
    public string nombre;
    public string descripcion;

    //mamda dos tipo objeto.
    public static event EventHandler Agarrar;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sinLuz;
    }

    protected void agarrar()
    {
        Agarrar?.Invoke(this, EventArgs.Empty);
    }


    private void OnMouseOver()
    {
        spriteRenderer.sprite = conLuz;
    }
    private void OnMouseExit()
    {
        spriteRenderer.sprite = sinLuz;
    }

    public string getNombre()
    {
        return nombre;
    }

    public string getDescripcion()
    {
        return descripcion;
    }
}
