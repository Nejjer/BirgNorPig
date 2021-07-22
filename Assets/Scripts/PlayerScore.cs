using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScore : MonoBehaviour
{
    [SerializeField] GameObject _scoreText;
    private int _score;

    public void AddScore()
    {
        _score += 1;
        _scoreText.GetComponent<Text>().text = _score.ToString();
    }

    
}
