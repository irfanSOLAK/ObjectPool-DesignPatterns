using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D _bulletRigidbody2D;
    float _bulletSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        _bulletRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToRight();
    }

    private void MoveToRight()
    {
        _bulletRigidbody2D.MovePosition((Vector2)transform.position + Vector2.right.normalized * _bulletSpeed * Time.deltaTime);
    }
}
