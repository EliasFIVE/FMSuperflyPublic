using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [Header("Set In Inpector")]
    [SerializeField] private GameObject pooledObjectPrefab;
    //WebGl build not supports Instantiate of object in runtime, all object should by created in inspector
    //[SerializeField] private int pooledBaseAmount = 10; 
    //[SerializeField] private bool canGrow = true;
    [SerializeField] List<GameObject> pooledObjects;

    private void Awake()
    {
        //WebGl build not supports Instantiate of object in runtime, all object should by created in inspector
        //pooledObjects = new List<GameObject>();
    }
    private void Start()
    {
        //WebGl build not supports Instantiate of object in runtime, all object should by created in inspector
/*      for (int i = 0; i < pooledBaseAmount; i++) 
        {
            NewObjectInPool(pooledObjectPrefab);
        }*/

    }

    public GameObject GetPooledObject()
    {
        for (int i= 0; i< pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
                return pooledObjects[i];
        }

        //WebGl build not supports Instantiate of object in runtime, all object should by created in inspector
/*        if (canGrow)
            return NewObjectInPool(pooledObjectPrefab);*/

        Debug.LogWarning("There are no free objects in pool left");
        return null;
    }
    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }

    private GameObject NewObjectInPool(GameObject prefab)
    {
        GameObject obj = (GameObject)Instantiate(prefab);
        obj.transform.SetParent(this.gameObject.transform);
        pooledObjects.Add(obj);
        obj.SetActive(false);
        return obj;
    }   
}
