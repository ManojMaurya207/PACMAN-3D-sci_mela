using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SCORE : MonoBehaviour
{
    public GameObject scoreDisplay;
    public GameObject scoreDisplay2;
    public int score;
    public bool addingscore = false;
    public float scoreDelay = 0.35f;

    void Update()
    {
        if (addingscore == false)
        {
            addingscore = true;
            StartCoroutine(Addingscore());
        }
        
    }
    IEnumerator Addingscore()
    {
        score += 1;
        scoreDisplay.GetComponent<Text>().text = "" + score;
        scoreDisplay2.GetComponent<Text>().text = "" + score;
        yield return new WaitForSeconds(scoreDelay);
        addingscore = false;
    }
}

