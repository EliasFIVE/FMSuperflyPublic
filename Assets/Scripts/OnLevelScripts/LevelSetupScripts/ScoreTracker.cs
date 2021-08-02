using UnityEngine;

public class ScoreTracker : Singleton<ScoreTracker>
{
    [Header("Set In Inspector")]
    [SerializeField] private int initialScore = 0;

    [Header("Set Dynamicaly")]
    [SerializeField] private int score;
    
    [HideInInspector] public Events.EventIntegerEvent ScoreChangeEvent;
    [HideInInspector] public Events.EventIntegerEvent NewScoreValueEvent;
    
    public void ChangeScorePointsByValue(int value)
    {
        int changeValue = value;

        if ((score + changeValue) < 0)
            changeValue = -score;

        score += changeValue;

        ScoreChangeEvent.Invoke(changeValue);
        NewScoreValueEvent.Invoke(score);
    }

    public void SetScoreToInitialValue()
    {
        score = initialScore;
        NewScoreValueEvent.Invoke(score);
    }
}

