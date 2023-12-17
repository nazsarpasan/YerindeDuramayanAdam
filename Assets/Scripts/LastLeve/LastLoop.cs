using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastLoop : MonoBehaviour
{

    public GameObject LastCarPrefab;
    public GameObject LastFade;
    public AudioSource carBreak;
    public AudioSource sansiii;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Karakter1"))
            {

            EndLoop();
            }
    }

    public void EndLoop()
    {
        Debug.Log("aCalýsýor");
        GameObject yeniPrefab = Instantiate(LastCarPrefab, new Vector3(10, -3, 0), Quaternion.identity);
        LastFade.SetActive(true);
        carBreak.Play();
        sansiii.Play();
        StartCoroutine(ScenePass());
        
    }

    IEnumerator ScenePass()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }
}
