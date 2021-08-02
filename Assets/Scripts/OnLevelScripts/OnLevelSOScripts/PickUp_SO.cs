using UnityEngine;


[CreateAssetMenu(fileName = "NewPickUp", menuName = "InGameAssets/PickUp", order = 0)]
public class PickUp_SO : ScriptableObject
{
    [SerializeField] private int pickUpValue;
    [SerializeField] private Material carreerMaterial;

    public int Value
    {
        get { return pickUpValue; }
    }

    public Material CarreerMaterial
    {
        get { return carreerMaterial; }
    }
}
