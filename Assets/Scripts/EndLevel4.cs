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
            // Objeyi sa�a ve yukar� y�nde s�rekli olarak hareket ettirme
            float hareketX = hareketHizi * Time.deltaTime;
            float hareketY = hareketHizi * Time.deltaTime;

            // Yeni pozisyonu hesapla ve g�ncelle
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
      
        Debug.Log("cal�s�yor");
        kusAnimator.enabled = true;
        StartCoroutine(WaitTillKarga());


    }

    IEnumerator WaitTillKarga()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 
    


}
