using UnityEngine;

public class libro : MonoBehaviour
{
    public Sprite sinLuz;
    public Sprite conLuz;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sinLuz;
    }

    private void OnMouseOver()
    {
        spriteRenderer.sprite = conLuz;
    }
    private void OnMouseExit()
    {
        spriteRenderer.sprite = sinLuz;
    }
}
