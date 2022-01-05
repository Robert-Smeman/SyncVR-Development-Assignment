using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DestroySelfOverTime : MonoBehaviour
{
    //Destroys the spawned cubes
   private void Start()
   {
       Destroy(gameObject, 1.5f);
   }
}