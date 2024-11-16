using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    /*public static Inventario instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);

        }
    }*/

    private List<ObjetoSimple> inventario = new List<ObjetoSimple>();
    private int indice = 0;
    private ObjetoSimple objetoActual = null;


    public void agregarObjeto(ObjetoSimple objetoNuevo)
    {
        if (objetoNuevo != null && !inventario.Contains(objetoNuevo))
        {
            inventario.Add(objetoNuevo);
            Debug.Log("se agrego " + objetoNuevo.getNombre() + " " + inventario[inventario.Count-1]);

        }
    }

    public void quitarObjeto(string nombre)
    {
        foreach (ObjetoSimple obj in inventario)
        {
            if (obj.getNombre() == nombre)
            {
                inventario.Remove(obj);
                Debug.Log("se removio " + obj.getNombre());
            }
        }
    }



    public void mostrarInventario()
    {
        if (objetoActual != null)
        {
            Destroy(objetoActual);
        }

        if (indice >= 0 && inventario.Count <= indice)
        {
            objetoActual = Instantiate(inventario[indice], this.transform);
        }
    }
    private void proximoObjeto()
    {
        if ((indice+1) < inventario.Count)
            this.indice += 1;
        mostrarInventario();
    }
    private void anteriorObjeto()
    {
        if (indice - 1 < 0)
        {
            indice = 0;
        }
        else
        { 
            indice -= 1; 
        }
        mostrarInventario();
    }



    public bool consultaPorNombre(string nombre)
    {
        foreach (ObjetoSimple obj in inventario)
        {
            if (obj.getNombre() == nombre) {
                return true;               
            }
        }
        return false;
    }
}
