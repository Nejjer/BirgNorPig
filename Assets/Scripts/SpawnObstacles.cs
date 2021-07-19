using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    [SerializeField] GameObject _obstacle;

    public void StartGame()
    {
        StartCoroutine("Spawn");
        Instantiate(_obstacle, new Vector2(transform.position.x, Random.Range(-1f, 2.4f)), Quaternion.identity);

    }


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RestartSpawn()
    {
        StartCoroutine("Spawn");

    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(_obstacle, new Vector2(transform.position.x, Random.Range(-1f,2.4f)), Quaternion.identity);
        RestartSpawn();
    }
}
