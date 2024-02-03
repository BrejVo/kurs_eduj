using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceenChanger : MonoBehaviour
{
    public string SceenName;
    [SerializeField] Button ChangeButton;


    void Start()
    {
        ChangeButton.onClick.AddListener(() => SceneChange());
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(SceenName);
    }

    // Update is called once per frame

}
