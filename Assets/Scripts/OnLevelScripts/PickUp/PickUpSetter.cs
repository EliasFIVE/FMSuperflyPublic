using UnityEngine;

public class PickUpSetter : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private PickUp_SO pickUpSettings;

    public PickUp_SO PickUpSettings
    {
        get { return pickUpSettings; }
    }
}
