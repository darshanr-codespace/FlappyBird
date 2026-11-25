using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public static bool MovementStopped { get; private set; }
    public float moveSpeed = 5;
    public float deadZone = -29.62f;

    public static void StopMovement()
    {
        MovementStopped = true;
    }

    public static void ResetMovement()
    {
        MovementStopped = false;
    }

    void Update()
    {
        if (MovementStopped)
            return;

        transform.position = transform.position + (moveSpeed * Time.deltaTime * Vector3.left);
        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
