using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    bool isLeft = false;
    bool isRight = false;

    public Rigidbody2D rb;
    public float velocidad;

    public void clickLeft()
    {
        isLeft = true;
    }

    public void releaseLeft()
    {
        isLeft = false;
    }

    public void clickRight()
    {
        isRight = true;
    }

    public void releaseRight()
    {
        isRight = false;
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
    }
}
