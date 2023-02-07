using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eatable_destroy : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject coinCount;
    public static int piont = 0;
    public SCORE pointScript;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //effect.SetActive(true);
            Destroy(gameObject);
            coinCount.GetComponent<Text>().text = "" + piont;
            

        }
    }
}
