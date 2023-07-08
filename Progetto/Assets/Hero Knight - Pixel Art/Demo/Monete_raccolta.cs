using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Monete_raccolta : MonoBehaviour
{
    int monete = 0;
    public TextMeshProUGUI contaMoneteText;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
       if (collision.name.Contains("Basic front coin")){

       monete++;
       collision.gameObject.SetActive(false);
       AggiornaConteggioMonete();
       }

       }
   
      void AggiornaConteggioMonete(){
        contaMoneteText.SetText("Monete: " + monete);
      }
   }

