using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] GameObject _button;
    

    public void OnClick()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
