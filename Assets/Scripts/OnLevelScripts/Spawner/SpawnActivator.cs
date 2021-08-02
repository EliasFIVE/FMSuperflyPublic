using System.Collections.Generic;
using UnityEngine;

public class SpawnActivator : MonoBehaviour
{
    private List<PoolSpawner> spawners;

    private void Awake()
    {
        spawners = new List<PoolSpawner>(GetComponentsInChildren<PoolSpawner>());
    }
    private void Start()
    {
        ActivateSpawners();
    }

    public void ActivateSpawners()
    {
        foreach (PoolSpawner spawner in spawners)
        {
            spawner.InitiateSpawn();
        }
    }

    public void StopSpawners()
    {
        foreach (PoolSpawner spawner in spawners)
        {
            spawner.StopSpawn();
        }
    }
}
