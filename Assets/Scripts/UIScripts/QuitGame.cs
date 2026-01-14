using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Da collegare al bottone UI
    public void Quit()
    {
        Debug.Log("Quit Game"); // utile per test in Editor
        Application.Quit();
    }
}
