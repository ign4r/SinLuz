using UnityEngine;

public class playerController : MonoBehaviour
{
    void Update()
    {
        //capturo camara, capturo donde ta el mouse,
        //transformo lo del mouse a global, muevo el objeto, dejo la z fija en 3
        Camera mainCamera = Camera.main;
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        worldPos.z = 3;
        transform.position = worldPos;
    }
}
