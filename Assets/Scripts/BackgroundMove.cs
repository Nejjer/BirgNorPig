using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] float _speed = -5f;
    [SerializeField] GameObject _player;
    private float _sizeX;
    private float _pos = 0;
    private void Start()
    {
        _sizeX = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    

    private void Update()
    {
        if (_player.GetComponent<PlayerMove>().GetStateGame())
        {
            Move();
        }
    }

    private void Move()
    {
        _pos += _speed * Time.deltaTime;
        _pos = Mathf.Repeat(_pos, _sizeX);
        transform.position = new Vector2(_pos, 0f);
    }
}
