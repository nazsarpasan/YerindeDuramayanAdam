
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;


public class MainCharacter : MonoBehaviour
{


    [SerializeField]

    public GameObject panel;
    public bool IsMainCharacter;

    Rigidbody2D rigitbody;

    public Animator animator;

    public CinemachineVirtualCamera cmv;

    public float horizontal;

    public GameObject karakter2;

    public AudioSource gibberishSpeak;

    void Start()
    {
        rigitbody = GetComponent<Rigidbody2D>();


        /*if (typeof(MainCharacter).IsPublic)
        {
            
            IsMainCharacter = true;
        }*/


    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform == karakter2)
        {

            if (collision.gameObject.GetComponent<MainCharacter>().IsMainCharacter == false)
            {

                IsMainCharacter = false;


                collision.gameObject.GetComponent<MainCharacter>().IsMainCharacter = true;
            }
        }

    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Karakter2")
        {
            gibberishSpeak.Play();
            panel.SetActive(true);
            print("mahmut");
            if (collision.gameObject.GetComponent<MainCharacter>().IsMainCharacter == false)
            {

                IsMainCharacter = false;


                collision.gameObject.GetComponent<MainCharacter>().IsMainCharacter = true;

                if (transform.tag == "Karakter1")
                {
                    animator.SetBool("IsIdle", true);
                    animator.SetBool("IsWalking", false);

                }


                Carpma();
            }
        }



    }



    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (!IsMainCharacter)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else
        {

            MoveCharacter();

        }


    }

    void MoveCharacter()

    {
        rigitbody.velocity = new Vector2(horizontal * 3, 0);

        /* if (Input.GetAxis("Horizontal") > 0)
         {
             transform.position += transform.right * Time.deltaTime;
         }
         else if (Input.GetAxis("Horizontal") < 0)
         {
             transform.position -= transform.right * Time.deltaTime;
         }*/



        if (horizontal != 0)
        {
            print("mahmut");
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);

        }
        else
        {
            animator.SetBool("IsIdle", true);
            animator.SetBool("IsWalking", false);
        }
    }

    void Carpma()
    {
        cmv.m_Follow = karakter2.transform;
    }
}






