using UnityEngine;

public class TurretController : MonoBehaviour
{
    [Header("Movimento verticale")]
    public float raiseHeight = 2f;
    public float raiseSpeed = 4f;

    [Header("Oggetto da spostare insieme")]
    public Transform linkedObject;   // oggetto che si muove insieme

    private Vector2 basePosition;
    private Vector2 raisedPosition;

    private Vector2 linkedBasePosition;
    private Vector2 linkedRaisedPosition;

    private bool isRaised = false;
    private bool isFullyRaised = false;

    void Start()
    {
        basePosition = transform.position;
        raisedPosition = basePosition + Vector2.up * raiseHeight;

        if (linkedObject != null)
        {
            linkedBasePosition = linkedObject.position;
            linkedRaisedPosition = linkedBasePosition + Vector2.up * raiseHeight;
        }
    }

    void Update()
    {
        MoveTurret();
    }

    void OnMouseDown()
    {
        if (!isRaised)
        {
            isRaised = true; // si alza con il click
        }
    }

    void MoveTurret()
    {
        if (!isRaised || isFullyRaised)
            return;

        // Muove la torretta
        transform.position = Vector2.Lerp(
            transform.position,
            raisedPosition,
            Time.deltaTime * raiseSpeed
        );

        // Muove anche l'oggetto collegato
        if (linkedObject != null)
        {
            linkedObject.position = Vector2.Lerp(
                linkedObject.position,
                linkedRaisedPosition,
                Time.deltaTime * raiseSpeed
            );
        }

        // Controllo arrivo
        if (Vector2.Distance(transform.position, raisedPosition) < 0.01f)
        {
            transform.position = raisedPosition;

            if (linkedObject != null)
                linkedObject.position = linkedRaisedPosition;

            isFullyRaised = true;
        }
    }
}




