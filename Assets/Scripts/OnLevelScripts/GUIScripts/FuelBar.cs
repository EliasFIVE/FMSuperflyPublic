using UnityEngine;

public class FuelBar : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private RectTransform fuelbarRectTransform;
    [SerializeField] private GameObject fuelBarBackground;
    [SerializeField] private float maxBarValue = 100f;
    private float maxBarWidth;

    [Header("Set Dynamicaly")]
    [SerializeField] private int fuelValue = 50;
    private void Awake()
    {
        maxBarWidth = fuelBarBackground.GetComponent<RectTransform>().sizeDelta.x;
    }

    public void UpdateFuelUI(int value)
    {
        fuelValue = value;
        float relativeFuelValue = (float)fuelValue / maxBarValue;
        float currentBarWidth = maxBarWidth * relativeFuelValue;
        Vector2 barSize = new Vector2(currentBarWidth, fuelbarRectTransform.sizeDelta.y);
        fuelbarRectTransform.sizeDelta = barSize;
    }
}
