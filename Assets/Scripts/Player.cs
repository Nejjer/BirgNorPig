using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField] float _jumpForce = 5f;
    [SerializeField] GameObject _textScore;
    [SerializeField] GameObject _textGameOver;
    [SerializeField] GameObject _SpawnerObstacle;
    [SerializeField] GameObject _buttonRestart;
    private int _score = 0;
    private bool _isAlive = true;
    private Rigidbody2D _rb;
    private bool _firstTap = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.Sleep();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")) && _isAlive)
        {
            _rb.velocity = new Vector2(0, _jumpForce);
            if (!_firstTap)
            {
                _SpawnerObstacle.GetComponent<SpawnObstacles>().StartGame();
                _firstTap = true;
                _rb.IsAwake();
            }
        }
        
    }

    public int GetScore()
    {
        return _score;
    }
    public void AddScore()
    {
        _score += 1;
        _textScore.GetComponent<Text>().text = _score.ToString();
    }

    public void Death()
    {
        _isAlive = false;
        _textGameOver.SetActive(true);
        _buttonRestart.SetActive(true);
    }
}
