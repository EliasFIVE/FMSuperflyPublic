using System.Collections.Generic;
using UnityEngine;

public class CloudPackActivator : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private List<GameObject> cloudsInPack;

    private void OnEnable()
    {
        ActivateRandomCloudsInPack();
    }

    public void ActivateRandomCloudsInPack()
    {
        float trashhold = gameObject.GetComponentInParent<CloudsSetUp>().CloudsTrashhold;
        bool active;
        foreach (GameObject cloud in cloudsInPack)
        {
            if (Random.value <= trashhold)
                active = true;
            else
                active = false;
            cloud.SetActive(active);
        }
    }
}
