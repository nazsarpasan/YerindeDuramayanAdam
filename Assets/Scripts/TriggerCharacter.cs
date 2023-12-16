using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCharacter : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Karakter2"))
        {
            panel.SetActive(true);

        }
       
        
    }
}
