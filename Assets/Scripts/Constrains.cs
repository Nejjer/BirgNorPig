using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constrains : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player _player))
        {
            _player.Death();
        }
    }
}
