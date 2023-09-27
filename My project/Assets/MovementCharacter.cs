using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{

    [Header ("Movimiento")]
    public float moveSpeed = 5f;
    private bool lookright = true;
    private Rigidbody2D rb;
    
    [Header ("Salto")]
    public LayerMask Floor;
    public float jump;

    [Header ("Animacion")]
    private Animator animator;

    private void Start ()
    {
        animator = GetComponent<Animator>();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //Movimiento Horizontal
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput != 0f)
        {
            animator.SetBool("isRunning", true);
        }else
        {
            animator.SetBool("isRunning", false);
        }
        
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        Orientacion(moveInput); 
        JumpProcess();
    }

    //bool IsItOnFloor()
    
        //RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.2f, Floor);
        //return raycastHit.collider ≠ null;

    void JumpProcess()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }

    void Orientacion(float moveInput)
    {
        if((lookright == true && moveInput < 0) || (lookright == false && moveInput > 0))
        {
            lookright = !lookright;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
