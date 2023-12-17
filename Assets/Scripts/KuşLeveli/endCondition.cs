using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endCondition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.CompareTag("EndLevel"))
        {

            StartCoroutine(WaitPls());
        }
       
    }

    IEnumerator WaitPls()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
