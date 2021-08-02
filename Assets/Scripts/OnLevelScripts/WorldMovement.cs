using UnityEngine;

public class WorldMovement : MonoBehaviour
{
    private Transform objectTransform;

    private void Awake()
    {
        objectTransform = gameObject.transform;
    }
    private void LateUpdate()
    {
        Vector3 newPosition = objectTransform.position;
        newPosition.z -= LevelSettings.Instance.WorldMoveSpeed * Time.deltaTime;
        objectTransform.position = newPosition;
    }
}
