using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_script : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject enemy;

    void Update()
    {
        if (collect_Controle.scoureCount == 213)
        {
            winScreen.SetActive(true);
            enemy.SetActive(false);
        }
    }
    
}
