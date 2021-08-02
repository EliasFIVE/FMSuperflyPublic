using UnityEngine;
using UnityEngine.UI;

public class InGameGUIButtons : MonoBehaviour
{
    [Header("Set in Inspector")]
    [SerializeField] private Button pauseButton;

    private void Start()
    {
        pauseButton.onClick.AddListener(HandlePauseClicked);
    }

    private void HandlePauseClicked()
    {
        GameManager.Instance.TogglePause();
    }
}
