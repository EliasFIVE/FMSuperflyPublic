using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    private float speed = 0;

    private void OnEnable()
    {
        speed = gameObject.GetComponentInParent<CloudsSetUp>().CloudsSpeed;
    }
    void LateUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
