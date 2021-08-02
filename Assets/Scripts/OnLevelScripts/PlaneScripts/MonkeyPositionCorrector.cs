using UnityEngine;

public class MonkeyPositionCorrector : MonoBehaviour
{
    private AvatarMover avatar;
    private MonkeyMover monkey;
    void Start()
    {
        avatar = gameObject.GetComponentInChildren<AvatarMover>();
        monkey = gameObject.GetComponentInChildren<MonkeyMover>();
    }
    private void Update()
    {
        CorrectMonkeyPosition();
    }
    private void CorrectMonkeyPosition()
    {
        monkey.MoveToPosition(new Vector3(avatar.Transform.position.x, avatar.Transform.position.y - 0.5f, avatar.Transform.position.z));
    }
}
