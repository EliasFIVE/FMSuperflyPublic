using UnityEngine;

public class LevelStartSetup : MonoBehaviour
{
    private ScoreTracker score;
    private FuelTracker fuel;

    private void Awake()
    {
        score = GetComponentInChildren<ScoreTracker>();
        fuel = GetComponentInChildren<FuelTracker>();
    }
    private void Start()
    {
        ResetAllTrackersValues();
    }

    private void ResetAllTrackersValues()
    {
        score.SetScoreToInitialValue();
        fuel.SetFuelToInitialValue();
    }
}
