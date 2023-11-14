using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton<ObjectPool>
{
    private GameObject _objectPrefab;

    private List<GameObject> _objectsListInPool;

    private int _objectsAmountInPool = 5;

    public GameObject ObjectFromPool
    {
        get
        {
            if (_objectsListInPool.Count == 0)
            {
                CreateTemporaryObject();
            }

            DestroyRedundantTemporaryObjects();
            return _objectsListInPool[0];
        }
    }


    // Start is called before the first frame update
    public override void Awake()
    {
        base.Awake();
        LoadObjectPrefab();
        CreatePoolList();
        CreateObjectsForPool();
    }

    private void LoadObjectPrefab()
    {
        _objectPrefab = Resources.Load<GameObject>("Prefabs/Bullet");
    }

    private void CreatePoolList()
    {
        _objectsListInPool = new List<GameObject>();
    }

    private void CreateObjectsForPool()
    {
        while (_objectsListInPool.Count < _objectsAmountInPool)
        {
            GameObject objectToPool = Instantiate(_objectPrefab, transform.position, Quaternion.identity);
            objectToPool.SetActive(false);
            _objectsListInPool.Add(objectToPool);
        }
    }

    public void AddObjectToPool(GameObject pooledObject)
    {
        _objectsListInPool.Add(pooledObject);
        pooledObject.SetActive(false);
    }

    public void DeleteObjectFromPool(int index = 0)
    {
        _objectsListInPool.RemoveAt(index);
    }

    private void CreateTemporaryObject()
    {
        GameObject temporaryObject = Instantiate(_objectPrefab, transform.position, Quaternion.identity);
        temporaryObject.SetActive(false);
        _objectsListInPool.Add(temporaryObject);
    }

    private void DestroyRedundantTemporaryObjects()
    {
        while (_objectsAmountInPool < _objectsListInPool.Count)
        {
            GameObject temporaryObject = _objectsListInPool[_objectsAmountInPool];
            _objectsListInPool.RemoveAt(_objectsAmountInPool);
            Destroy(temporaryObject);
        }
    }

}
