using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public AudioSource coinSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // E�er �arp��an obje "Player" etiketine sahipse
        {
            // Collectible'� yok et
            Destroy(gameObject);

            coinSound.Play();
        }
    }
}
