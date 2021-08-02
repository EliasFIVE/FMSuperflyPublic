using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AlarmSound : MonoBehaviour
{
    public AudioClip fuelAlarmSound;
    private AudioSource alarm;

    void Awake()
    {
        alarm = gameObject.GetComponent<AudioSource>();
    }
    private void Start()
    {
        FuelTracker.Instance.LowFuelEvent.AddListener(LowFuelValueHandler);
    }
    private void LowFuelValueHandler()
    {
        alarm.PlayOneShot(fuelAlarmSound);
    }
}
