using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float velocidadY = 3f;

    public Action<Bullet> onDesactivar; //variable que contiene un metodo;

    void Update()
    {
        transform.Translate(0, velocidadY * Time.deltaTime, 0);
    }

    private void OnBecameInvisible()
    {
        onDesactivar(this);
    }
}
