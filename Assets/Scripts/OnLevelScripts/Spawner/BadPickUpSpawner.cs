public class BadPickUpSpawner : PoolSpawner
{
    public override void InitiateSpawn()
    {
        StartCoroutine(SpawnObjectCoroutine(LevelSettings.Instance.BadPickUpSpawnTime));
    }
    protected override void SpawnPoolObject()
    {
        base.SpawnPoolObject();
        lastSpawnedObject.GetComponentInChildren<PickUpCarreerConstructor>().ConstructBadPickUp();
    }
}
