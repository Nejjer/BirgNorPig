using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideConstrains : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerMove>(out PlayerMove _player))
        {
            _player.SetAlive(false);
        }
    }
}
