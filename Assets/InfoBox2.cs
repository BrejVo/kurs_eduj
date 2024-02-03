using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoBox2 : MonoBehaviour
{
    [SerializeField] Button FirstButton;
    [SerializeField] Button SecondButton;
    public string PlayervsBot;

    public void SceneChange()
    {
        SceneManager.LoadScene(PlayervsBot);
    }

    void Start()
    {
        FirstButton.onClick.AddListener(() => CloseInfo());
    }

    public void CloseInfo()
    {
        gameObject.SetActive(false);
        SecondButton.gameObject.SetActive(false);
    }
}
