using UnityEngine;
using UnityEngine.UI;

public class collect_Controle : MonoBehaviour
{

    public static int scoureCount;
    public GameObject scoreDisplay;
    public GameObject scoreEndDisplay;
    void Update()
    {
        
        scoreDisplay.GetComponent<Text>().text = "" + scoureCount;
        scoreEndDisplay.GetComponent<Text>().text = "" + scoureCount;
    }
}
