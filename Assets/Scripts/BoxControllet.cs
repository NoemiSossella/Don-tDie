using UnityEngine;

public class BoxController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool hasFallen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f; // fermo all'inizio
    }

    void OnMouseDown()
    {
        if (!hasFallen)
        {
            rb.gravityScale = 1f; // inizia a cadere
            hasFallen = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Killer"))
        {
            // Disattiva l'oggetto Killer
            other.gameObject.SetActive(false);

            // NON fermiamo il Rigidbody, continua a cadere
        }
    }
}



