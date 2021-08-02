using System.Collections;
using UnityEngine;

public class PoolSpawner : MonoBehaviour
{
    [SerializeField] private float defaultSpawnTime = 1;

    [Header ("Set dynamicaly")]
    [SerializeField] private bool spawnIsActive = true; //to track spawn in inspetor

    private ObjectPooler objectPool;
    private SpawnPoints spawnPoints;
    protected GameObject lastSpawnedObject;

    private void Awake()
    {
        objectPool = GetComponent<ObjectPooler>();
        spawnPoints = GetComponentInChildren<SpawnPoints>();
    }

    protected IEnumerator SpawnObjectCoroutine(float spawnTime)
    {
        spawnIsActive = true;
        while (spawnIsActive)
        {
            yield return new WaitForSeconds(spawnTime);
            SpawnPoolObject();
        }
        spawnIsActive = false;
    }
    protected virtual void SpawnPoolObject()
    {
        GameObject spawnedObject = objectPool.GetPooledObject();
        lastSpawnedObject = spawnedObject;
        spawnedObject.transform.position = spawnPoints.GetFreeRandomSpawnPosition();
        spawnedObject.SetActive(true);
    }

    public virtual void InitiateSpawn()
    {
        StartCoroutine(SpawnObjectCoroutine(defaultSpawnTime));
    }
    public void StopSpawn()
    {
        StopAllCoroutines();
    }
}
