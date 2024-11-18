using UnityEngine;

public class Radio : ObjetoSimple
{

    [SerializeField] AudioSource distorsion;
    [SerializeField] AudioSource musica;

    private void OnMouseDown()
    {
        distorsion.Stop();
        musica.Play();
    }
    
}
