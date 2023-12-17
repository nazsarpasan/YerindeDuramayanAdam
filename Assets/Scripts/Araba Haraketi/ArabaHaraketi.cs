using UnityEngine;

public class ArabaHaraketi : MonoBehaviour
{
    public float yatayHareketHizi = 5f;
    public float dikeyHareketHizi = 5f;

    void Update()
    {
        // Yatay hareket kontrolü
        float yatayHareket = Input.GetKey(KeyCode.D) ? 1f : 0f;

        // Dikey hareket kontrolü
        float dikeyHareket = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            dikeyHareket = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dikeyHareket = -1f;
        }

        // Hareket vektörünü oluştur
        Vector2 hareket = new Vector2(yatayHareket * yatayHareketHizi, dikeyHareket * dikeyHareketHizi);

        // Hareket vektörünü normalize et ve hızla çarp
        hareket.Normalize();
        hareket *= yatayHareketHizi * Time.deltaTime;

        // Nesneyi hareket ettir
        transform.Translate(hareket);
    }
}
