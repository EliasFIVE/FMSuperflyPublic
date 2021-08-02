using UnityEngine;

public abstract class PickUpAbsorbtion : MonoBehaviour
{
    protected int pickUpValue;

    private void Start()
    {
        pickUpValue = gameObject.GetComponent<PickUpSetter>().PickUpSettings.Value;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<AvatarMover>() != null)
        {
            AbsorbPickUp();
            gameObject.SetActive(false);
        }
    }

    public abstract void AbsorbPickUp();
}
