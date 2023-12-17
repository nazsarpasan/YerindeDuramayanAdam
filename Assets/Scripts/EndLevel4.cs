using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel4 : MonoBehaviour
{
    public float hareketHizi = 2f;
    private bool hareketEtmekte = false;
    public GameObject ku�;
    private Animator ku�Animator;
    

    void Update()
    {
        if (hareketEtmekte)
        {
            // Objeyi sa�a ve yukar� y�nde s�rekli olarak hareket ettirme
            float hareketX = hareketHizi * Time.deltaTime;
            float hareketY = hareketHizi * Time.deltaTime;

            // Yeni pozisyonu hesapla ve g�ncelle
            Vector2 yeniPozisyon = new Vector2(ku�.transform.position.x + hareketX, ku�.transform.position.y + hareketY);
            ku�.transform.position = yeniPozisyon;
        }

    }

    void Start()
    {
        ku�Animator = ku�.GetComponent<Animator>();


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
        ku�Animator.enabled = true;
        StartCoroutine(WaitTillKarga());


    }

    IEnumerator WaitTillKarga()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 
    


}
