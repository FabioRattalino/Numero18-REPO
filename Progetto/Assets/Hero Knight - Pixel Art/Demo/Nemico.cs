using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Nemico : MonoBehaviour
{
    public float velocita = 400;
    public LayerMask filtroNemico;
    bool isCambioDirezione = false;
    Rigidbody2D rb;
    
  private  void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        int moltiplicatoreDirezione = Convert.ToInt32(isCambioDirezione) - 1;
        float direzione = Mathf.Sign(moltiplicatoreDirezione);
        rb.velocity = new Vector2( velocita * Time.deltaTime * direzione , rb.velocity.y);

        if (Physics2D.Linecast(transform.position, transform.position + Vector3.right * direzione, filtroNemico))
        {
            print("OK");
            isCambioDirezione = !isCambioDirezione;
        }
    }
}