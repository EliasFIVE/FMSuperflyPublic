using UnityEngine;

public class PlaneRotation : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] Transform avatarTransform;
    [SerializeField] float avatarPositionToRotationSpeedMultiplier;

    private AvatarJumper avatarJumper;

    private void Awake()
    {
        avatarJumper = gameObject.GetComponentInChildren<AvatarJumper>();
    }
    void Update()
    {
        if(!avatarJumper.AvatarJumping)
            PlaneRoll(GetRotationSpeedFromAvatarPosition());
    }

    void PlaneRoll(float rotationSpeed)
    {
        gameObject.transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime, Space.Self);
    }

    public void PlanePitch(float rotationSpeed)
    {
        gameObject.transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0, Space.Self);
    }
    float GetRotationSpeedFromAvatarPosition()
    {
        float avatarOffsetFromCenter = avatarTransform.localPosition.x;
        float rotationSpeed = avatarOffsetFromCenter * avatarPositionToRotationSpeedMultiplier;
        return rotationSpeed;
    }


}
