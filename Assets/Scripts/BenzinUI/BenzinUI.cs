using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class BenzinUI : MonoBehaviour
{
  //sayýlar
    public TextMeshProUGUI litreSayaç;
    private int litre = 30;


    //fill
    public GameObject fillButton;
    public GameObject allPanel;
    public AudioSource fillSound;
    public AudioSource gibbereishStop;

    private void Start()
    {
        litre = Random.Range(30,60);
    }
    public void Decrease()
    {
        litre -= 1;
        litreSayaç.text = litre.ToString();

        if (litre == 48)
        {
            fillButton.SetActive(true);
        }
         else
        {
            fillButton.SetActive(false);

        }
    }
    public void Increase()
    {
        litre += 1;
        litreSayaç.text = litre.ToString();

        if (litre==48)
        {
            fillButton.SetActive(true);
        }
        else
        {
            fillButton.SetActive(false);

        }
    }

    public void Fill()
    {
        allPanel.SetActive(false);
        fillSound.Play();
        gibbereishStop.Stop();
        StartCoroutine(ScenePass());

    }

   IEnumerator ScenePass()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
       
    }
}
