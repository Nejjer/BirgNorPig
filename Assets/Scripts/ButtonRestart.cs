using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonRestart : MonoBehaviour
{
    [SerializeField] GameObject _button;
    private void Start()
    {
        _button.SetActive(false);

    }

    public void OnClick()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
