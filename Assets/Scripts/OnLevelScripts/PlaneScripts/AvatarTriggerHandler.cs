using UnityEngine;

public class AvatarTriggerHandler : MonoBehaviour
{    private void OnTriggerEnter(Collider other)
    {
        print("Collision with " + other.gameObject.name.ToString());
        if (other.gameObject.GetComponent<PickUpAbsorbtion>() != null)
        {
            other.gameObject.GetComponent<PickUpAbsorbtion>().AbsorbPickUp();
            other.gameObject.SetActive(false);
        }
    }
}
