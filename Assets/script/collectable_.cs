using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable_ : MonoBehaviour
{

    public AudioSource pointFx;
  

    void OnTriggerEnter(Collider other)
    {
        pointFx.Play();
        collect_Controle.scoureCount += 1;
        this.gameObject.SetActive(false);
        

    }
}
