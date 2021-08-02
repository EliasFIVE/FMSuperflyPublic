using UnityEngine;

public class InGameGUIExternalConnector : MonoBehaviour
{
    private FuelBar fuelBar;
    private ScoreGUI scoreGUI;

    private void Awake()
    {
        fuelBar = GetComponentInChildren<FuelBar>();
        scoreGUI = GetComponentInChildren<ScoreGUI>();
    }
    private void OnEnable()
    {
        if(fuelBar != null)
            FuelTracker.Instance.NewFuelValueEvent.AddListener(fuelBar.UpdateFuelUI);

        if (scoreGUI != null)
            ScoreTracker.Instance.NewScoreValueEvent.AddListener(scoreGUI.UpdateScoreUI);
    }
}
