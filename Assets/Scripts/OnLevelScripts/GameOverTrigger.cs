using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<AvatarMover>() != null)
            GameManager.Instance.OnPlayerDeath();
    }
}
