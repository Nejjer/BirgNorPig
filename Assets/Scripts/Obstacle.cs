using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float _speed = 0.05f;
    void Start()
    {
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player _player))
        {
            _player.AddScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player _player))
        {
            _player.Death();
        }
    }

    //Двигаем
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * _speed);
        // уничтожаем объект
        if (transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }
}
