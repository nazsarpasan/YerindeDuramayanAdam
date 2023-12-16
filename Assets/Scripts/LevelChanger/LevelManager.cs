using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject fadeOut;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            // �stedi�iniz sahne ad�n� a�a��daki "YeniSahneAdi" de�i�kenine atay�n

            fadeOut.SetActive(true);
            // Sahneyi de�i�tir
            StartCoroutine(Delay());
        }
    }

    private IEnumerator Delay()
    {
        
        string yeniSahneAdi = "InsideCarNaz";
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(yeniSahneAdi);

    }
}
