using UnityEngine;

public class Cargador : ObjetoSimple
{
    [SerializeField] private Celular phone;
    [SerializeField] private Inventario inventory;
    private void OnMouseDown()
    {
        agarrar();
        gameObject.SetActive(false);
        itemUI.gameObject.SetActive(true);

    }

    public void ChargePhone()
    {
        if (inventory.consultaPorNombre("Celular"))
        {
            phone.Charged();
        }
       
    }
}

