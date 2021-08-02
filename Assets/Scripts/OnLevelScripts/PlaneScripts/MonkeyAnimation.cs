using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MonkeyAnimation : MonoBehaviour
{
    private Animator animator;
    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    public void PlayScoreChangeAnimation(int scoreChangeValue)
    {
        if (scoreChangeValue <= 0)
            PlayHitAnimation();
    }
    private void PlayHitAnimation()
    {
        animator.SetTrigger("Hit");
    }

    public void ToggleMoveAnimation()
    {
        animator.SetBool("IsMoving", !animator.GetBool("IsMoving"));
    }

    public void PlayJumpAnimation()
    {
        Debug.Log("JumpCall");
        animator.SetTrigger("Jump");
    }
}
