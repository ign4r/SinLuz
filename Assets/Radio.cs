using UnityEngine;

public class Radio : ObjetoSimple
{
    [SerializeField] private AudioSource aSource;
    [SerializeField] private AudioClip aClip;
    private void OnMouseDown()
    {
        aSource.clip = aClip;
        aSource.Play();

    }
    
}
