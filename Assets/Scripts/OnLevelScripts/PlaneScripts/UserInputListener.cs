using UnityEngine;

public class UserInputListener : MonoBehaviour
{
    private bool nonZeroHorizontalInputTrigger = true; //initial value, will switch to false on start and first input signal
    private AvatarMover avatarMove;
    private AvatarJumper avatarJump;
    //private MonkeyAnimation animationController;
    //private MonkeyMover monkey;

    private float horizontalInput;
    private float verticalInput;
    private float jumpInput;

    private void Awake()
    {
        avatarMove = gameObject.GetComponentInChildren<AvatarMover>();
        avatarJump = gameObject.GetComponentInChildren<AvatarJumper>();
        //animationController = gameObject.GetComponentInChildren<MonkeyAnimation>();
        //monkey = gameObject.GetComponentInChildren<MonkeyMover>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");

        ToggleNonHorizontalZeroInput(horizontalInput == 0);

        if (horizontalInput != 0)
            HandleNonZeroHorizontalInput(horizontalInput);

        if (verticalInput != 0)
            HandleNonZeroVerticalInput(verticalInput);

        if (jumpInput != 0)
            HandleNonZeroJumpInput();
    }

    private void ToggleNonHorizontalZeroInput(bool inputSignal)
    {
        if (nonZeroHorizontalInputTrigger != inputSignal)
        {
            nonZeroHorizontalInputTrigger = !nonZeroHorizontalInputTrigger;
            //animationController.ToggleMoveAnimation();
        }
    }
    private void HandleNonZeroHorizontalInput(float horizontalInput)
    {
        avatarMove.Move(horizontalInput);
        //monkey.RotateMonkey(horizontalInput);
    }

    private void HandleNonZeroVerticalInput(float verticalInput)
    {
        if (verticalInput > 0)
            avatarJump.ActivateJump();
    }

    private void HandleNonZeroJumpInput()
    {
        avatarJump.ActivateJump();
    }
}
