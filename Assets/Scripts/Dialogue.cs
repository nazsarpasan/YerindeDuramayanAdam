using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Dialogue : MonoBehaviour
{
    public static Dialogue Instance;
    public GameObject button;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    private void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }


    private void Start()
    {
        textComponent.text = string.Empty;
         Dialogue.Instance.StartDialogue();
       
    }






    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }


    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {

        if(index< lines.Length -1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }

        else
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }

  
}
