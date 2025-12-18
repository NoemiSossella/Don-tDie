using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform puntoB;
    public float velocita = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (puntoB == null) return;

        Vector3 direzione = (puntoB.position - transform.position).normalized;

        // Movimento solo su X e Z, Y gestita dalla gravit�
        rb.linearVelocity = new Vector2(
            direzione.x * velocita,
            rb.linearVelocity.y
        );
    }
}