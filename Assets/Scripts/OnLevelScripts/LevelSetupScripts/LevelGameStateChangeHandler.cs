using UnityEngine;

public class LevelGameStateChangeHandler : MonoBehaviour
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
        Debug.Log("Reset Values");
        score.SetScoreToInitialValue();
        fuel.SetFuelToInitialValue();
    }
}
