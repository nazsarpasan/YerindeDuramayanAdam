using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTheUI : MonoBehaviour
{
    public GameObject UIpanel;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.CompareTag("Panel");
        {
            UIpanel.SetActive(true);
           
                
            

        }
    }
}
