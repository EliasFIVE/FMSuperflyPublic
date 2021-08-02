using System.Collections;
using UnityEngine;

public class PlaneOutOfFuelHandler : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private float rotationSpeed = 10f;

    private PlaneRotation plane;
    private PropellerSpin propeller;
    private AudioSource engineAudio;

    private void Awake()
    {
        plane = gameObject.GetComponentInChildren<PlaneRotation>();
        propeller = gameObject.GetComponent<PropellerSpin>();
        engineAudio = gameObject.GetComponent<AudioSource>();
    }
    public void HandleOutOfFuel()
    {
        propeller.StopPropellerSpin();
        engineAudio.Stop();
        ActivateOutOfFuelRotation();
    }

    void ActivateOutOfFuelRotation()
    {
        StartCoroutine(OutOfFuelRotation());
    }
    IEnumerator OutOfFuelRotation()
    {
        while(true)
        {
            yield return new WaitForEndOfFrame();
            plane.PlanePitch(rotationSpeed);
        }
    }
}
