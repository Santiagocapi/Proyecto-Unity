using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asjfdhav : MonoBehaviour
{
    bool isLeft = false;
    bool isRight = false;
    bool isJump = false;
    bool canJump = true;

    public Rigidbody2D rb;
    public float velocidad;
    public float jumpForce;
    public float waitJump;
    public SpriteRenderer spr;
    public void clickLeft()
    {
        isLeft = true;
        spr.flipX = true;
    }

    public void releaseLeft()
    {
        isLeft = false;
    }

    public void clickRight()
    {
        isRight = true;
        spr.flipX = false;
    }

    public void releaseRight()
    {
        isRight = false;

    }

    public void clickJump()
    {
        isJump = true;
    }

    private void FixedUpdate()
    {
        if(isLeft)
        {
            rb.AddForce(new Vector2(-velocidad,0) * Time.deltaTime);
        }

        if(isRight)
        {
            rb.AddForce(new Vector2(velocidad,0) * Time.deltaTime);
        }

        if(isJump && canJump)
        {
            isJump = false;
            rb.AddForce(new Vector2(0, jumpForce));
            canJump= false;
            Invoke("waitToJump", waitJump);
        }
    }

    void waitToJump ()
    {
        canJump = true;
    }
}

