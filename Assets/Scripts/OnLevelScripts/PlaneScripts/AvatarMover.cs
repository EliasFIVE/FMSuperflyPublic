using UnityEngine;

public class AvatarMover : MonoBehaviour
{
    [Header("Set Dynamicaly")]
    [SerializeField] private float avatarMoveSpeed = 0f;

    private AvatarJumper avatarJumper;
    private Transform avatarTransform;
    public Transform Transform
    {
        get { return avatarTransform; }
    }

    private void Awake()
    {
        avatarTransform = gameObject.transform;
        avatarJumper = gameObject.GetComponent<AvatarJumper>();
    }

    public void Move(float moveValue)
    {
        if (!avatarJumper.AvatarJumping)
        {
            Vector3 currentPosition = avatarTransform.localPosition;
            currentPosition.x += moveValue * avatarMoveSpeed * Time.deltaTime;
            avatarTransform.localPosition = currentPosition;
        }      
    }

    public void SetAvatarMoveSpeed(float value)
    {
        avatarMoveSpeed = value;
    }
}
