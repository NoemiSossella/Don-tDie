using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [Header("Sparo")]
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 8f;
    public float fireRate = 1f;

    [Header("Movimento verticale")]
    public float raiseHeight = 2f;
    public float raiseSpeed = 4f;

    private float fireTimer;
    private Vector2 basePosition;
    private Vector2 raisedPosition;
    private bool isRaised = false;
    private bool canRaise = true; // 👈 QUESTA MANCAVA

    void Start()
    {
        basePosition = transform.position;
        raisedPosition = basePosition + Vector2.up * raiseHeight;
    }

    void Update()
    {
        HandleShooting();
        MoveTurret();
    }

    void HandleShooting()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= fireRate)
        {
            fireTimer = 0f;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.left * bulletSpeed;
        }

        Destroy(bullet, 3f);
    }

    void OnMouseDown()
    {
        if (canRaise)
        {
            isRaised = true;
            canRaise = false;
        }
    }


    void MoveTurret()
    {
        Vector2 targetPosition = isRaised ? raisedPosition : basePosition;
        transform.position = Vector2.Lerp(transform.position, targetPosition, Time.deltaTime * raiseSpeed);
    }
}


