using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] float _speed = -2f;
    private Transform _transform;
    private float _size;
    private float _pos;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _size = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _pos = _speed * Time.time;
        _pos = Mathf.Repeat(_pos, _size);
        _transform.position = new Vector3(_pos, 0f,0);
    }
}
