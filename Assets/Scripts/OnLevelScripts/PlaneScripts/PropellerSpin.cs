using System.Collections;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private Transform propellerTransform;
    [SerializeField] private float rotationAngleSpeed = 1440;

    void Start()
    {
        ActivatePropellerSpin();
    }

    public void ActivatePropellerSpin()
    {
        StartCoroutine(SpinPropeller());
    }

    IEnumerator SpinPropeller()
    {
        while (true)
        {
            propellerTransform.Rotate(Vector3.forward, rotationAngleSpeed * Time.deltaTime, Space.Self);
            yield return new WaitForEndOfFrame();
        }
    }

    public void StopPropellerSpin()
    {
        StopAllCoroutines();
    }
}
