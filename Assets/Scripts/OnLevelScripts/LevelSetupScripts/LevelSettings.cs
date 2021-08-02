using UnityEngine;

public class LevelSettings : Singleton<LevelSettings>
{
    [Header("Speed settings")]
    [SerializeField] private float worldMoveSpeed = 5f;
    [SerializeField] private float playerBaseSpeed = 2f;

    [Header("PickUp spawn settings")]
    [SerializeField] private float bananaPickUpSpawntime;
    [SerializeField] private float badPickUpSpawnTime;
    [SerializeField] private float fuelPickUpSpawnTime;

    public float WorldMoveSpeed
    {
        get { return worldMoveSpeed; }
    }

    public float BananaPickUpSpawntime
    {
        get { return bananaPickUpSpawntime; }
    }

    public float BadPickUpSpawnTime
    {
        get { return badPickUpSpawnTime; }
    }

    public float FuelPickUpSpawnTime
    {
        get { return fuelPickUpSpawnTime; }
    }

    public float PlayerBaseSpeed
    {
        get { return playerBaseSpeed; }
    }
}
