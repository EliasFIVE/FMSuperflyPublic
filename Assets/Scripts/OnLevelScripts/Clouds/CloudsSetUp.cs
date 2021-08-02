using UnityEngine;

public class CloudsSetUp : MonoBehaviour
{
    [SerializeField] private float cloudsSpeed;
    [SerializeField] [Range(0f, 1f)] private float cloudsDensityTrashhold = 0.6f;

    public float CloudsSpeed
    {
        get { return cloudsSpeed; }
    }

    public float CloudsTrashhold
    {
        get { return cloudsDensityTrashhold; }
    }
}
