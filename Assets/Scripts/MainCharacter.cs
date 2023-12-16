using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{


    [SerializeField]

    public bool IsMainCharacter;

    Rigidbody2D rigitbody;




    void Start()
    {
        
        /*if (typeof(MainCharacter).IsPublic)
        {
            
            IsMainCharacter = true;
        }*/

        rigitbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Karakter2")
        {
            print("mahmut");
            if (collision.gameObject.GetComponent<MainCharacter>().IsMainCharacter == false)
            {

                IsMainCharacter = false;


                collision.gameObject.GetComponent<MainCharacter>().IsMainCharacter = true;
            }
        }

    }


    
    void Update()
    {
        
        if (!IsMainCharacter)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else
        {
            rigitbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }


}



