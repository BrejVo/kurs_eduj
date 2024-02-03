using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoBox : MonoBehaviour
{
    [SerializeField] Button FirstButton;
    [SerializeField] Button SecondButton;
    [SerializeField] Button showbutton;
    [SerializeField] Button Menu;
    [SerializeField] SpriteRenderer Dice;
    void Start()
    {
        FirstButton.onClick.AddListener(()=> CloseInfo());
    }

    public void CloseInfo()
    {
        gameObject.SetActive(false);
        SecondButton.gameObject.SetActive(false);
        showbutton.gameObject.SetActive(true);
        Dice.gameObject.SetActive(true);
        Menu.gameObject.SetActive(true);
    }
}
