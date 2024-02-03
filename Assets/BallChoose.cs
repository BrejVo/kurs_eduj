using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChoose : MonoBehaviour
{
    [SerializeField] SpriteRenderer shadow1;
    [SerializeField] SpriteRenderer shadow2;
    public static int spritedecision = 0;
    void Start()
    {
        CheckDecision();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FirstBallChoice()
    {
        spritedecision = 0;
        shadow1.gameObject.SetActive(true);
        shadow2.gameObject.SetActive(false);
    }

    public void SecondBallChoice()
    {
        spritedecision = 1;
        shadow1.gameObject.SetActive(false);
        shadow2.gameObject.SetActive(true);
    }

    void CheckDecision()
    {
        if (spritedecision == 0)
        {
            shadow1.gameObject.SetActive(true);
            shadow2.gameObject.SetActive(false);
        }
        else if (spritedecision == 1)
        {
            shadow1.gameObject.SetActive(false);
            shadow2.gameObject.SetActive(true);
        }
    }
}
