using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathReset : MonoBehaviour
{
    private bool isDead = false;

    // Chiama questo metodo quando il player muore
    public void Die()
    {
        if (isDead) return;
        isDead = true;

        //Ricarica la scena corrente
        UiManager.Instance.ShowGameOver();

        Debug.Log("Sono oltre ShowGameOver");
    }

    // ESEMPIO: muore se tocca un oggetto killer
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            Debug.Log("Sono morto");
            Die();
        }
    }
}

