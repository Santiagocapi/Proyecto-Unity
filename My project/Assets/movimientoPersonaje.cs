using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    
    void Update()
    {
        ProcesarMoviemiento();
    }

    void ProcesarMoviemiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
        Rigidbody2D.rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocidad = new Vector2(inputMovimiento * velocidadMovimiento, rigidbody.velocidad.y);
    }
}
