using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDespawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        ObjectPool.Instance.AddObjectToPool(other.gameObject);
    }
}
