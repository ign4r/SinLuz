using System.Collections;
using UnityEngine;

public class SoundRandom : MonoBehaviour
{
    public AudioSource audioSource; // El componente de AudioSource que reproducirá los sonidos
    public AudioClip[] soundClips;  // Array de clips de audio a reproducir
    public float interval = 2f;     // Intervalo de tiempo entre cada sonido

    private Coroutine soundCoroutine; // Referencia a la corutina activa

    void Start()
    {
        // Inicia la corutina al comenzar el juego
        soundCoroutine = StartCoroutine(PlaySounds());
    }

    void Update()
    {
      

    }

    IEnumerator PlaySounds()
    {
        while (true) // Loop infinito para reproducir los sonidos continuamente
        {
            foreach (AudioClip clip in soundClips)
            {
                if (audioSource != null && clip != null)
                {
                    audioSource.clip = soundClips[Random.Range(0,soundClips.Length)];
                    audioSource.Play();
                    Debug.Log($"Reproduciendo: {clip.name}");
                }

                // Espera antes de reproducir el siguiente sonido
                yield return new WaitForSeconds(interval);
            }
        }
    }
}
