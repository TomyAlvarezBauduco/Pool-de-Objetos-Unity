using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public List<Bullet> listaDeBalas = new List<Bullet> ();

    public int cargadorInicial = 5;

    public Bullet prefabBala;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cargadorInicial; i++)
        {
            Bullet clon = Instantiate(prefabBala,this.transform);
            listaDeBalas.Add(clon);
            clon.gameObject.SetActive(false);
            clon.onDesactivar = DevolverBulletALista;


        }
    }

    public void DevolverBulletALista(Bullet bala)
    {
        bala.gameObject.SetActive(false);
        listaDeBalas.Add(bala);
    }
    public Transform DispararBala()
    {
        Transform balaDisparada;
        if (listaDeBalas.Count > 0)
        {
            Bullet balaSiguiente = listaDeBalas[0];
            listaDeBalas[0].gameObject.SetActive(true);
            listaDeBalas.Remove(balaSiguiente);
            balaDisparada = balaSiguiente.transform;
        }
        else
        {
            Bullet clon = Instantiate(prefabBala, this.transform);
            listaDeBalas.Add(clon);
            clon.gameObject.SetActive(false);
            clon.onDesactivar= DevolverBulletALista;
            balaDisparada = clon.transform;
        }
        return balaDisparada;

    }

}
