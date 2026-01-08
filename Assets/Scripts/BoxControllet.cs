using UnityEngine;
using System.Collections;
public class BoxControllet : MonoBehaviour
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            // Disattiva L'OGGETTO COLPITO
            collision.gameObject.SetActive(false);

            // Ferma la caduta
            rb.linearVelocity = Vector2.zero;
            rb.gravityScale = 0f;
        }
    }
}


