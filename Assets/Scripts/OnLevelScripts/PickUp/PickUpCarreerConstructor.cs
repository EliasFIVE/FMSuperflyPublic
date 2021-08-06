using System.Collections.Generic;
using UnityEngine;

public class PickUpCarreerConstructor : MonoBehaviour
{

    [Header("PickUp types")]
    [SerializeField] private PickUpSetter badPickUp;
    [SerializeField] private PickUpSetter fuelPickUp;
    [SerializeField] private PickUpSetter bananPickUp;

    private void OnEnable()
    {
        DeactivateAllPickUps();
    }


    public void ConstructBadPickUp()
    {
        SetMaterials(badPickUp.PickUpSettings.CarreerMaterial);
        badPickUp.gameObject.SetActive(true);
    }

    public void ConstructBananaPickUp()
    {
        SetMaterials(bananPickUp.PickUpSettings.CarreerMaterial);
        bananPickUp.gameObject.SetActive(true);
    }

    public void ConstructFuelPickUp()
    {
        SetMaterials(fuelPickUp.PickUpSettings.CarreerMaterial);
        fuelPickUp.gameObject.SetActive(true);
    }

    private void SetMaterials(Material material)
    {
        var balloons = GetComponentsInChildren<MaterialSetter>();
        foreach (var balloon in balloons)
        {
            balloon.SetMaterial(material);
        }
    }
    private void DeactivateAllPickUps()
    {
        badPickUp.gameObject.SetActive(false);
        fuelPickUp.gameObject.SetActive(false);
        bananPickUp.gameObject.SetActive(false);
    }
}
