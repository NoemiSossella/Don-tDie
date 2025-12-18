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

        // Ricarica la scena corrente
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // ESEMPIO: muore se tocca un oggetto killer
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            Die();
        }
    }
}

