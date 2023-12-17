using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class BenzinUI : MonoBehaviour
{
  //say�lar
    public TextMeshProUGUI litreSaya�;
    private int litre = 30;

    //fill
    public GameObject fillButton;
    public GameObject allPanel;
    public AudioSource fillSound;

    public void Decrease()
    {
        litre -= 2;
        litreSaya�.text = litre.ToString();

        if (litre == 48)
        {
            fillButton.SetActive(true);
        }
    }
    public void Increase()
    {
        litre += 2;
        litreSaya�.text = litre.ToString();

        if (litre==48)
        {
            fillButton.SetActive(true);
        }
    }

    public void Fill()
    {
        allPanel.SetActive(false);
        fillSound.Play();
        StartCoroutine(ScenePass());
    }

   IEnumerator ScenePass()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
       
    }
}
