using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] Inventario inventario;
    void Start()
    {
        ObjetoSimple.Agarrar += agregar;
    }

    private void agregar(object obj,object data)
    {
        inventario.agregarObjeto((ObjetoSimple)obj);

    }
   
}
