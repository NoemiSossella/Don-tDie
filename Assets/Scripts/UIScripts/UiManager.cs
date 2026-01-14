using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject gamePanel;
    public GameObject pausePanel;
    public GameObject gameOverPanel;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        DisableAllPanels();
        mainMenuPanel.SetActive(true);
    }

    public void ShowGameUI()
    {
        DisableAllPanels();
        gamePanel.SetActive(true);
    }

    public void ShowPause()
    {
        DisableAllPanels();
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void HidePause()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ShowGameOver()
    {
        DisableAllPanels();
        gameOverPanel.SetActive(true);
    }

    private void DisableAllPanels()
    {
        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(false);
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }
}

