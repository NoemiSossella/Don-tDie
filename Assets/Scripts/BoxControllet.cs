using UnityEngine;
using System.Collections;
public class BoxControllet : MonoBehaviour
{
    public GameObject objectToDisable;

    private Rigidbody2D rb;
    private bool hasFallen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // Non cade all'inizio
    }

    // Click del mouse sull’oggetto
    void OnMouseDown()
    {
        if (!hasFallen)
        {
            rb.gravityScale = 1f; // Inizia a cadere
            hasFallen = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Se colpisce un oggetto con tag Killer
        if (collision.gameObject.CompareTag("Killer"))
        {
            if (objectToDisable != null)
            {
                objectToDisable.SetActive(false);
            }

            // Ferma l’oggetto
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
        }
    }
}

