using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public GameObject pausePanel;

    // Bottone RESUME
    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    // Bottone RELOAD / RESTART
    public void ReloadScene()
    {
        Time.timeScale = 1f; // IMPORTANTISSIMO
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
