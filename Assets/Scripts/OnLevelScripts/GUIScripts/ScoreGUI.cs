using UnityEngine;
using UnityEngine.UI;

public class ScoreGUI : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private Text scoreText;
    
    [Header("Set Dynamicaly")]
    [SerializeField] private int scoreValue = 0;

    private void Start()
    {
        UpdateScoreText(scoreValue);
    }
    public void AddValueToScoreText(int value)
    {
        scoreValue += value;
        UpdateScoreText(scoreValue);
    }

    public void UpdateScoreUI(int value)
    {
        scoreValue = value;
        UpdateScoreText(scoreValue);
    }

    private void UpdateScoreText(int score)
    {
        string scoreString = score.ToString();
        scoreText.text = scoreString;
    }
}
