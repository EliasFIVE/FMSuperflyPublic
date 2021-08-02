using UnityEngine;

public class CloudPackResetPosition : MonoBehaviour
{   
    [Header("Set In Inspector")]
    [SerializeField] private float xPositionLimit;
    [SerializeField] private float xAnchorPosition;

    private CloudPackActivator cloudsActivator;

    private void Awake()
    {
        cloudsActivator = gameObject.GetComponent<CloudPackActivator>();
    }
    void Update()
    {
        if (gameObject.transform.position.x >= xPositionLimit)
            ResetCloudPack();
    }

    private void ResetCloudPack()
    {
        gameObject.transform.position = new Vector3(xAnchorPosition, gameObject.transform.position.y, gameObject.transform.position.z);
        cloudsActivator.ActivateRandomCloudsInPack();
    }
}
