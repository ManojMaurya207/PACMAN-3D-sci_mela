using UnityEngine;
using UnityEngine.SceneManagement;

public class pac_collision : MonoBehaviour
{
    public packman_movement movement;
    public float restartDelay = 2f;
    public GameObject endScreen;
    public GameObject BOARD;

    private bool isGameOver = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !isGameOver)
        {
            isGameOver = true;
            movement.enabled = false;
            Invoke("ShowEndScreen", restartDelay);
        }
    }

    void ShowEndScreen()
    {
        endScreen.SetActive(true);
        BOARD.SetActive(false);
    }

   
}
