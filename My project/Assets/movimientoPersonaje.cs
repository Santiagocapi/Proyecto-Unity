using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonaje : MonoBehaviour
{

    private velocidadPersonaje;

    void Update () {
        personajeMovimiento();
    }

    void personajeMovimiento () {

        float inputMovimiento = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocidad = new Vector2 (inputMovimiento * velocidad, rigidbody.velocidad.y);

    }

}
