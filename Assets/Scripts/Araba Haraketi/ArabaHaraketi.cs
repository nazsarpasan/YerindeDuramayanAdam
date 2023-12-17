using UnityEngine;

public class ArabaHaraketi : MonoBehaviour
{
    public float yatayHareketHizi = 5f;
    public float dikeyHareketHizi = 5f;

    void Update()
    {
        // Yatay hareket kontrol�
        float yatayHareket = Input.GetKey(KeyCode.D) ? 1f : 0f;

        // Dikey hareket kontrol�
        float dikeyHareket = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            dikeyHareket = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dikeyHareket = -1f;
        }

        // Hareket vekt�r�n� olu�tur
        Vector2 hareket = new Vector2(yatayHareket * yatayHareketHizi, dikeyHareket * dikeyHareketHizi);

        // Hareket vekt�r�n� normalize et ve h�zla �arp
        hareket.Normalize();
        hareket *= yatayHareketHizi * Time.deltaTime;

        // Nesneyi hareket ettir
        transform.Translate(hareket);
    }
}
