using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel4 : MonoBehaviour
{
    public float hareketHizi = 2f;
    private bool hareketEtmekte = false;
    public GameObject kus;
    private Animator kusAnimator;
    

    void Update()
    {
        if (hareketEtmekte)
        {
            // Objeyi saða ve yukarý yönde sürekli olarak hareket ettirme
            float hareketX = hareketHizi * Time.deltaTime;
            float hareketY = hareketHizi * Time.deltaTime;

            // Yeni pozisyonu hesapla ve güncelle
            Vector2 yeniPozisyon = new Vector2(kus.transform.position.x + hareketX, kus.transform.position.y + hareketY);
            kus.transform.position = yeniPozisyon;
        }

    }

    void Start()
    {
        kusAnimator = kus.GetComponent<Animator>();


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("EndLevel"))
        {
            EndScene();
        }
        
    }

    public void EndScene()
    {
        hareketEtmekte = true;
      
        Debug.Log("calýsýyor");
        kusAnimator.enabled = true;
        StartCoroutine(WaitTillKarga());


    }

    IEnumerator WaitTillKarga()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 
    


}
