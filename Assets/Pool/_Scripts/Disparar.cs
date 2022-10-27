using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Bullet prefabBala;
    public Pool pool;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pool.DispararBala().position = this.transform.position;
   
            //hay que chekear si quedan balas en la pool
            //y si no quedan, ampliar lista
        }
    }

}
