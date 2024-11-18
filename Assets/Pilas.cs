using UnityEngine;

public class Pilas : ObjetoSimple
{
    [SerializeField] playerController player;
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);
        player.SetFlashlight();
    }
}
