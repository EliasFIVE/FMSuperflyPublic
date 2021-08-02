public class FuelPickUpSpawner : PoolSpawner
{
    public override void InitiateSpawn()
    {
        StartCoroutine(SpawnObjectCoroutine(LevelSettings.Instance.FuelPickUpSpawnTime));
    }
    protected override void SpawnPoolObject()
    {
        base.SpawnPoolObject();
        lastSpawnedObject.GetComponentInChildren<PickUpCarreerConstructor>().ConstructFuelPickUp();
    }
}
