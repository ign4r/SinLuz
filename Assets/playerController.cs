using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    [SerializeField] Light2D _light2D;
    void Update()
    {

        Camera mainCamera = Camera.main;
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
        worldPos.z = 3;
        transform.position = worldPos;

       
    }
    public void SetFlashlight()
    {
        _light2D.intensity = 0.4f;
    }
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
