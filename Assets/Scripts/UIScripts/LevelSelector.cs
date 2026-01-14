using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject levelSelectorPanel;

    // Bottone LEVEL SELECT
    public void OpenLevelSelector()
    {
        Debug.Log("Open Level Selector");

        pausePanel.SetActive(false);
        levelSelectorPanel.SetActive(true);

        Time.timeScale = 0f; // gioco in pausa
    }

    // Bottone BACK (dal Level Selector)
    public void BackToPause()
    {
        levelSelectorPanel.SetActive(false);
        pausePanel.SetActive(true);

        Time.timeScale = 0f; // resta in pausa
    }
}

