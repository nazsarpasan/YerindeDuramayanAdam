using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class KushUçması : MonoBehaviour
{

    public float jumpForce = 5.0f;
    public float forwardSpeed = 2.0f;
    private Rigidbody2D rb;
    public Animator MyAnimator;

    public float minY = -2.0f;   
    public float maxY = 4.0f;  
    





    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        MoveForward();
        HareketKontrol();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            

        }
        
    }

    void HareketKontrol()
    {

        Vector3 location = transform.position;
        location.y += forwardSpeed * Time.deltaTime;
        location.y = Mathf.Clamp(location.y, minY, maxY);     
        transform.position = location;
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        MyAnimator.SetBool("IsWalking", true);
        MyAnimator.SetBool("IsIdle", false);
    }

    void MoveForward()
    {
        rb.velocity = new Vector2(forwardSpeed, rb.velocity.y);
    }

    void LateUpdate()
    {
       
        Vector3 birdPosition = transform.position;
        birdPosition.z = -20; 
        Camera.main.transform.position = birdPosition;
        
    }
}
