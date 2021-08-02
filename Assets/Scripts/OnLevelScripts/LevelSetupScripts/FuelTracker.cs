using System.Collections;
using UnityEngine;

public class FuelTracker : Singleton<FuelTracker>
{
    [Header("Set In Inspector")]
    [SerializeField] private int initialFuel = 50;
    [SerializeField] private int maximumFuel = 100;
    [SerializeField] private int alarmFuelValue = 10;
    [SerializeField] private int fuel—onsumptionPerSecond = 1;

    [Header("Set Dynamicaly")]
    [SerializeField] private int fuel;

    [HideInInspector] public Events.EventIntegerEvent FuelChangeEvent = new Events.EventIntegerEvent();
    [HideInInspector] public Events.EventIntegerEvent NewFuelValueEvent = new Events.EventIntegerEvent();
    [HideInInspector] public Events.EventVoidEvent OutOfFuelEvent = new Events.EventVoidEvent();
    [HideInInspector] public Events.EventVoidEvent LowFuelEvent = new Events.EventVoidEvent();

    private void Start()
    {
        fuel = initialFuel;
        StartCoroutine(FuelConsumption());
        StartCoroutine(FuelAlarmCheck());
    }

    IEnumerator FuelConsumption()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            ChangeFuelByValue(-fuel—onsumptionPerSecond);
        }
    }

    public void ChangeFuelByValue(int value)
    {
        int changeValue = value;
        if ((fuel + changeValue) < 0)
            changeValue = -fuel;
        else if ((fuel + changeValue) > maximumFuel)
            changeValue = maximumFuel - fuel;

        fuel += changeValue;

        if (fuel <= 0)
            OutOfFuelHandler();

        FuelChangeEvent.Invoke(changeValue);
        NewFuelValueEvent.Invoke(fuel);
    }

    IEnumerator FuelAlarmCheck()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (fuel <= alarmFuelValue)
                LowFuelEvent.Invoke();
        }
    }
    private void OutOfFuelHandler()
    {
        StopAllCoroutines();
        OutOfFuelEvent.Invoke();
    }

    public void SetFuelToInitialValue()
    {
        fuel = initialFuel;
        NewFuelValueEvent.Invoke(fuel);
    }
}