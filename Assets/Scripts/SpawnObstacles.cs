using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;
    [SerializeField] float _timeBetweenSpawn = 2f;
    public void StartSpawn()
    {
        Instantiate(_obstacle, new Vector2(transform.position.x, Random.Range(-3.7f,3.7f)), Quaternion.identity);
        StartCoroutine("SpawnObstacle");

    }



    private void RestartCouritine()
    {
        StartCoroutine("SpawnObstacle");
    }

    IEnumerator SpawnObstacle()
    {
        yield return new WaitForSeconds(_timeBetweenSpawn);
        Instantiate(_obstacle, new Vector2(transform.position.x, Random.Range(-3.7f, 3.7f)), Quaternion.identity);
        RestartCouritine();
    }
}
