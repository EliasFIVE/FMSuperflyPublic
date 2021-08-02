using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private float planeSpeedMultiplier;

    private Transform planeTransform;

    void Awake()
    {
        planeTransform = gameObject.transform;
    }

    void Update()
    {
        MovePlane(GetMoveSpeedFromRotation());
    }

    void MovePlane(float moveSpeed)
    {
        Vector3 currentPosition = gameObject.transform.position;
        currentPosition.x += moveSpeed * Time.deltaTime;
        gameObject.transform.position = currentPosition;
    }

    float GetMoveSpeedFromRotation()
    {
        float moveSpeed = -planeTransform.rotation.z * planeSpeedMultiplier;
        return moveSpeed;
    }
}
