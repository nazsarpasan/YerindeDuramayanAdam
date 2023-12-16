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

            // Ýstediðiniz sahne adýný aþaðýdaki "YeniSahneAdi" deðiþkenine atayýn

            fadeOut.SetActive(true);
            // Sahneyi deðiþtir
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
