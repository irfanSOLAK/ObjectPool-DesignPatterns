using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private float _spawnTimeInSeconds = 1f;

    [SerializeField]
    private bool _isSpawning = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartObjectSpawning());
    }

    private IEnumerator StartObjectSpawning()
    {
        while (_isSpawning)
        {
            yield return new WaitForSeconds(_spawnTimeInSeconds);
            SpawnObject();
            DeleteObjectFromPool();
        }
    }

    private void SpawnObject()
    {
        GameObject pooledObject = ObjectPool.Instance.ObjectFromPool;
        pooledObject.transform.position = transform.position;
        pooledObject.SetActive(true);
    }

    private void DeleteObjectFromPool()
    {
        ObjectPool.Instance.DeleteObjectFromPool();
    }
}
