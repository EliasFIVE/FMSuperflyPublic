using UnityEngine;

public class PickUpCarreerConstructor : MonoBehaviour
{

    [Header("PickUp types")]
    [SerializeField] private PickUpSetter badPickUp;
    [SerializeField] private PickUpSetter fuelPickUp;
    [SerializeField] private PickUpSetter bananPickUp;

    private MaterialSetter balloon;

    private void Awake()
    {
        balloon = GetComponentInChildren<MaterialSetter>();
    }

    private void OnEnable()
    {
        DeactivateAllPickUps();
    }

    public void ConstructBadPickUp()
    {
        balloon.SetMaterial(badPickUp.PickUpSettings.CarreerMaterial);
        badPickUp.gameObject.SetActive(true);
    }

    public void ConstructBananaPickUp()
    {
        balloon.SetMaterial(bananPickUp.PickUpSettings.CarreerMaterial);
        bananPickUp.gameObject.SetActive(true);
    }

    public void ConstructFuelPickUp()
    {
        balloon.SetMaterial(fuelPickUp.PickUpSettings.CarreerMaterial);
        fuelPickUp.gameObject.SetActive(true);
    }

    private void DeactivateAllPickUps()
    {
        badPickUp.gameObject.SetActive(false);
        fuelPickUp.gameObject.SetActive(false);
        bananPickUp.gameObject.SetActive(false);
    }
}
