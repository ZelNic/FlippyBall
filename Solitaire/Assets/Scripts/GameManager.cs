using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        Application.targetFrameRate = 120;
    }

    public void RestartGame(float delay)
    {       
        Invoke("LoadMainScene", delay);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

}
