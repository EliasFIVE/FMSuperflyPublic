using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AvatarSounds : MonoBehaviour
{
    [Header("Set In Inspectro")]
    [SerializeField] private AudioClip gainScoreSound;
    [SerializeField] private AudioClip gainFuelSound;
    [SerializeField] private AudioClip loseScoreSound;
    private AudioSource scoreAudioSource;

    private void Awake()
    {
        scoreAudioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayScoreChangeSound(int scoreChangeValue)
    {
        if(scoreChangeValue > 0)
            scoreAudioSource.PlayOneShot(gainScoreSound);
        else if(scoreChangeValue < 0)
            scoreAudioSource.PlayOneShot(loseScoreSound);
    }

    public void PlayFuleChangeSound(int fuelChangeValue)
    {
        if (fuelChangeValue > 0)
            scoreAudioSource.PlayOneShot(gainFuelSound);
    }
}
