using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private List<Transform> spawnPoints;
    [SerializeField] private float reactivationTimeDelay = 1;

    [Header("Set Dynamicaly")]
    [SerializeField] private List<Transform> freeSpawnPoints;

    private void Start()
    {
        foreach (Transform point in spawnPoints)
        {
            ActivateSpawnPoint(point);
        }
    }
    private void ActivateSpawnPoint(Transform point)
    {
        freeSpawnPoints.Add(point);
        point.gameObject.SetActive(true );
    }
    public Vector3 GetFreeRandomSpawnPosition()
    {
        int index = Random.Range(0, freeSpawnPoints.Count);
        Transform point = freeSpawnPoints[index];
        Vector3 spawnPosition = point.position;

        DeactivateSpawnPoint(point);
        StartCoroutine(DelayedActivateSpawnPoint(point));

        return spawnPosition;
    }
    private void DeactivateSpawnPoint(Transform point)
    {
        freeSpawnPoints.Remove(point);
        point.gameObject.SetActive(false);
    }

    IEnumerator DelayedActivateSpawnPoint(Transform point)
    {
        yield return new WaitForSeconds(reactivationTimeDelay);
        ActivateSpawnPoint(point);
    }    
}
