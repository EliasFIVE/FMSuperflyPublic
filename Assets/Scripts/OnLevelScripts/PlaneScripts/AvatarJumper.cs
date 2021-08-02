using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class AvatarJumper : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private float jumpForce = 0;

    [Header("Set Dynamicaly")]
    [SerializeField] private bool isJumping = false;

    //private MonkeyAnimation animationController;
    private new Rigidbody rigidbody;

    public bool AvatarJumping
    {
        get { return isJumping; }
    }
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        //animationController = gameObject.GetComponentInChildren<MonkeyAnimation>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<PlaneMovement>() != null)
            EndJump();
    }

    public void ActivateJump()
    {
        if (!isJumping)
        {
            isJumping = true;
            JumpUp();
        }
    }
    private void JumpUp()
    {
        Vector3 force = Vector3.up * jumpForce;
        rigidbody.AddForce(force, ForceMode.Impulse);
        //animationController.PlayJumpAnimation();
    }

    private void EndJump()
    {
        isJumping = false;
    }
}
