using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollide : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    private GameObject _player;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMove>(out PlayerMove _player))
        {
            _player.SetAlive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerScore>(out PlayerScore _player))
        {
            _player.AddScore();
        }
    }

    private void FixedUpdate()
    {
        if (_player.GetComponent<PlayerMove>().GetStateGame())
        {
            Move();
        }
    }

    private void Move()
    {
        transform.Translate(Vector2.left * _speed);

        if (transform.position.x < -8f)
        {
            Destroy(gameObject);
        }
    }
}
