public class BananaPickUpSpawner : PoolSpawner
{
    public override void InitiateSpawn()
    {
        StartCoroutine(SpawnObjectCoroutine(LevelSettings.Instance.BananaPickUpSpawntime));
    }
    protected override void SpawnPoolObject()
    {
        base.SpawnPoolObject();
        lastSpawnedObject.GetComponentInChildren<PickUpCarreerConstructor>().ConstructBananaPickUp();
    }
}
