using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Kedy : MonoBehaviour
{
    [SerializeField]


    Rigidbody2D rigitbody;

    public Animator animator;

    public CinemachineVirtualCamera cmv;

    public float horizontal;

    public float vertical;

    public GameObject karakter2;


    public float FallingThreshold = -1f;
    [HideInInspector]
    public bool Falling = false;


    void Start()
    {
        rigitbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }
  
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (rigitbody.velocity.y < FallingThreshold)
        {
            Falling = true;
            animator.SetBool("IsFalling", true);
        }
        else
        {
            Falling = false;
            animator.SetBool("IsFalling", false);

        }

        if (Falling)
        {
            doSomethingWhenFalling();
        }

        MoveKedy();


        /* if (rigitbody.velocity.y < 0)
         {
             animator.SetBool("IsFalling", true);
         }
         else
         {
             animator.SetBool("IsIdle", true);
             animator.SetBool("IsFalling", false);
         }*/


    }

    private void doSomethingWhenFalling()
    {     
        Debug.Log("I've fallen and I can't get up!");
        
    }
    void MoveKedy()
    {
        rigitbody.velocity = new Vector2(horizontal * 3, 0);


        if (horizontal != 0)
        {
            print("mahmut");
            animator.SetBool("IsWalking", true);
            animator.SetBool("IsIdle", false);
           // animator.SetBool("IsFalling", false);

        }

       
        else
        {
            animator.SetBool("IsIdle", true);
            animator.SetBool("IsWalking", false);
            
        }
    }
    void CarpmaKedy()
    {
        cmv.m_Follow = karakter2.transform;
    }

}






   

    
   
    
        
