using UnityEngine;

public class ChangeRoom : ObjetoSimple
{
    [SerializeField] GameObject camMain;
    [SerializeField] GameObject camDireccion;
    [SerializeField] bool abierta;
    [SerializeField] Inventario inven;
    [SerializeField] AudioSource audioRadioSource; 


    private void OnMouseDown()
    {
        if (inven.consultaPorNombre("Llave") || abierta)
        {
            if (camDireccion.layer == LayerMask.NameToLayer("Cocina")) 
            {
                audioRadioSource.Play();
            }
            else
            {
                audioRadioSource.Stop();
            }
            camMain.SetActive(false);
            camDireccion.SetActive(true);
          
           
        }      
    }
}

