using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHaraketi : MonoBehaviour
{
   
    public float hareketHizi = 5f;
    public float hareketSuresi = 0.1f; // H�zlanma ve yava�lama s�resi
    private float hizZamani = 0f;
    private float hedefHiz = 0f;
    void Update()
    {
        float yatayHareket = Input.GetAxis("Horizontal");

        // Hedef h�z� belirle
        hedefHiz = yatayHareket * hareketHizi;

        // H�z� yumu�ak bir �ekilde g�ncelle
        float smoothHiz = Mathf.SmoothDamp(GetComponent<Rigidbody2D>().velocity.x, hedefHiz, ref hizZamani, hareketSuresi);

        // Hareket vekt�r�n� olu�tur
        Vector2 hareket = new Vector2(smoothHiz, 0);

        // Hareket vekt�r�n� normalize et ve h�zla �arp
        hareket.Normalize();
        hareket *= hareketHizi * Time.deltaTime;

        // Nesneyi hareket ettir
        transform.Translate(hareket);
    }
}
