using UnityEngine;

public class ResetCloudXGroupPosition : MonoBehaviour
{
    [SerializeField] private float zPositionLimit;
    [SerializeField] private float zAnchorPosition;
    void Update()
    {
        if (gameObject.transform.position.z <= zPositionLimit)
            ResetGloudGroup();
    }

    private void ResetGloudGroup()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, zAnchorPosition);
    }
}
