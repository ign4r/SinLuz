using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    void Update()
    {
        Camera mainCamera = Camera.main;
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        worldPos.z = 3;
        transform.position = worldPos;

       
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
