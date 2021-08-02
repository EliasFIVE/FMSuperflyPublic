using UnityEngine;

public class PlaneExternalConnector : MonoBehaviour
{
    private PlaneOutOfFuelHandler planeOutOfFuel;
    private AvatarSounds avatarSounds;
    private AvatarMover avatarMover;
    private MonkeyAnimation animationController;
    private void Awake()
    {
        planeOutOfFuel = gameObject.GetComponentInChildren<PlaneOutOfFuelHandler>();
        avatarMover = gameObject.GetComponentInChildren<AvatarMover>();
        if (gameObject.GetComponentInChildren<AvatarSounds>() != null)
            avatarSounds = gameObject.GetComponentInChildren<AvatarSounds>();
        if(gameObject.GetComponentInChildren<MonkeyAnimation>() !=null)
            animationController = gameObject.GetComponentInChildren<MonkeyAnimation>();
    }
    private void Start()
    {
        if (planeOutOfFuel != null)
            FuelTracker.Instance.OutOfFuelEvent.AddListener(planeOutOfFuel.HandleOutOfFuel);

        if (avatarSounds != null)
        {
            ScoreTracker.Instance.ScoreChangeEvent.AddListener(avatarSounds.PlayScoreChangeSound);
            FuelTracker.Instance.FuelChangeEvent.AddListener(avatarSounds.PlayFuleChangeSound);
        }

        if (animationController != null)
            ScoreTracker.Instance.ScoreChangeEvent.AddListener(animationController.PlayScoreChangeAnimation);

        avatarMover.SetAvatarMoveSpeed(LevelSettings.Instance.PlayerBaseSpeed);
    }    
}
