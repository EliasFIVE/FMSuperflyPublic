using UnityEngine;

public class DeactivateOnOutOfRange : MonoBehaviour
{
    private float deactivateZPosiotion;
    void Start()
    {
        deactivateZPosiotion = Camera.main.transform.position.z - 1f;
    }

    void Update()
    {
        if (gameObject.transform.position.z < deactivateZPosiotion)
            gameObject.SetActive(false);
    }
}
