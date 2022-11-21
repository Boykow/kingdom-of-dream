using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthcollecrible : MonoBehaviour
{
   [SerializeField]private float  healthVaule;

   private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player")
        {
             collision.GetComponent<Health>().AddHealth(healthVaule);
             gameObject.SetActive(false);
        }
   }
}
