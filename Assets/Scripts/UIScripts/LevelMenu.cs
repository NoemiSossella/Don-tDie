using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Carica livello per Build Index
    public void LoadLevel(int levelIndex)
    {
        Time.timeScale = 1f; // sicurezza
        SceneManager.LoadScene(levelIndex);
    }

    // Torna al menu principale
    public void BackToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); // Main Menu
    }
}
