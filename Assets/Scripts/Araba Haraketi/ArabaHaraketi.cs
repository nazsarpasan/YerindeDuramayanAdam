using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaHaraketi : MonoBehaviour
{
   
    public float hareketHizi = 5f;
    public float hareketSuresi = 0.1f; // Hýzlanma ve yavaþlama süresi
    private float hizZamani = 0f;
    private float hedefHiz = 0f;
    void Update()
    {
        float yatayHareket = Input.GetAxis("Horizontal");

        // Hedef hýzý belirle
        hedefHiz = yatayHareket * hareketHizi;

        // Hýzý yumuþak bir þekilde güncelle
        float smoothHiz = Mathf.SmoothDamp(GetComponent<Rigidbody2D>().velocity.x, hedefHiz, ref hizZamani, hareketSuresi);

        // Hareket vektörünü oluþtur
        Vector2 hareket = new Vector2(smoothHiz, 0);

        // Hareket vektörünü normalize et ve hýzla çarp
        hareket.Normalize();
        hareket *= hareketHizi * Time.deltaTime;

        // Nesneyi hareket ettir
        transform.Translate(hareket);
    }
}
