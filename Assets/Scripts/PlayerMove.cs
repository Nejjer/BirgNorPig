using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _jumpForce = 5f;
    [SerializeField] GameObject _obstacleSpawner;
    [SerializeField] GameObject _textGameOver;
    [SerializeField] GameObject _buttoRestart;
    private bool _alive = true;
    private Rigidbody2D _rb;
    private bool _firstTap = false;
    private bool _payingGame = false;

    public bool GetStateGame()
    {
        return _payingGame;
    }



    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.Sleep();
    }

    public void SetAlive(bool _live)
    {
        _alive = _live;
        _payingGame = _live;
        if (!_live)
        {
            _rb.Sleep();
            _textGameOver.SetActive(true);
            _buttoRestart.SetActive(true);

        }
    }

    private void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")) && _alive)
        {
            if (!_firstTap)
            {
                //Awake RB
                _rb.IsAwake();
                //Start spaen Obstacles
                _obstacleSpawner.GetComponent<SpawnObstacles>().StartSpawn();
                _firstTap = true;
                _payingGame = true;
            }
            
            _rb.velocity = new Vector2(0f, _jumpForce);
        }
        
    }
}
