using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Monete_raccolta : MonoBehaviour
{
    int monete = 0;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
       if (collision.name.Contains("Basic front coin")){

       monete++;
       collision.gameObject.SetActive(false);
       print("Ho raccolto una moneta e ne ho " + monete);


       }
   }
}
