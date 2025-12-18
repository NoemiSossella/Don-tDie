using UnityEngine;
using System.Collections;

public class FallingKiller2D : MonoBehaviour
{
    public float stopTime = 5f;

    private Rigidbody2D rb;
    private bool isStopped = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
    }

    // Uccide il player al contatto
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);

            // Oppure:
            // collision.gameObject.GetComponent<PlayerHealth>().Die();
        }
    }

    // Click con mouse (funziona anche in 2D)
    void OnMouseDown()
    {
        if (!isStopped)
            StartCoroutine(StopFalling());
    }

    IEnumerator StopFalling()
    {
        isStopped = true;

        rb.linearVelocity = Vector2.zero;
        rb.gravityScale = 0f;

        yield return new WaitForSeconds(stopTime);

        rb.gravityScale = 1f;
        isStopped = false;
    }
}
