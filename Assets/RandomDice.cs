using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using JetBrains.Annotations;

public class RandomDice : MonoBehaviour
{
    [SerializeField] Sprite[] spriteArray;
    [SerializeField] Sprite[] polandArray;
    [SerializeField]SpriteRenderer spriteRenderer;
    [SerializeField] Button ConfirmBTN;
    [SerializeField]SpriteRenderer sprite2;
    int playerScore;
    int enemyScore;
    private int finalResultPlayer;
    private int finalResultEnemy;
    public TextMeshProUGUI resultText;
    public TextMeshProUGUI enemyText;
    [SerializeField]SpriteRenderer Dice2;
    int decision = BallChoose.spritedecision;


    // Start is called before the first frame update
    void Start()
    {
        if (decision == 0)
        {
            Dice2.gameObject.SetActive(false);
            spriteRenderer.gameObject.SetActive(true);
        }
        else if (decision == 1)
        {
            Dice2.gameObject.SetActive(true);
            spriteRenderer.gameObject.SetActive(false);
        }
        ConfirmBTN.onClick.AddListener(() => StartCoroutine(ChooseDice()));
        spriteRenderer = GetComponent<SpriteRenderer>();
        Dice2 = GetComponent<SpriteRenderer>();
        
    }

    private void CompareResults()
    {
        if (ShowPLayerScore() > ShowEnemyScore())
        {
            finalResultPlayer++;
            Debug.Log($"Wygrywa gracz i dostaje punkt a punkt gracza to{enemyScore}");
            resultText.text = $"Wynik gracza: {finalResultPlayer}";
        }
        else if (ShowPLayerScore() < ShowEnemyScore())
        {
            finalResultEnemy++;
            Debug.Log($"Wygrywa bot i dostaje punkt a punkt gracza to {playerScore}");
            enemyText.text = $"Wynik bota: {finalResultEnemy}";
        }
        else
        {
            Debug.Log("Remis");
        }
    }


    public IEnumerator ChooseDice() 
    {
        int decision = BallChoose.spritedecision;
        spriteRenderer.color = Color.white;
        int i = 0;
        int randomNumbers = Random.Range(0, 6);
        int previousnumber = randomNumbers;
        

        while (i < 7)
        {
            if (i >= 1 && randomNumbers == previousnumber)
            {
                while(randomNumbers == previousnumber)
                {
                    randomNumbers = Random.Range(0, 6);
                }
            }
            previousnumber = randomNumbers;
        
            yield return new WaitForSeconds(0.2f);

            
            Debug.Log(randomNumbers);
            if(decision == 0)
            {
                spriteRenderer.sprite = spriteArray[randomNumbers];
            }
            else if(decision == 1)
            {
                Dice2.sprite = polandArray[randomNumbers];
            }
            i++;

            randomNumbers = Random.Range(0, 6);

        }
        i = 0;
        while (i < 4)
        {
            if (randomNumbers == previousnumber)
            {
                while (randomNumbers == previousnumber)
                {
                    randomNumbers = Random.Range(0, 6);
                }
            }
            previousnumber = randomNumbers;

            yield return new WaitForSeconds(0.5f);


            Debug.Log(randomNumbers);
            if (decision == 0)
            {
                spriteRenderer.sprite = spriteArray[randomNumbers];
            }
            else if (decision == 1)
            {
                Dice2.sprite = polandArray[randomNumbers];
            }
            playerScore = randomNumbers;
            i++;
            if (i < 4)
            {
                randomNumbers = Random.Range(0, 6);
            }

        }
        spriteRenderer.color = Color.green;
        Debug.Log("KONIEC LOSOWANIA GRACZA");
        yield return new WaitForSeconds(1f);
        Debug.Log($"Wynik gracza to: {playerScore}");

        // LOSOWANIE KOMPA
        sprite2.color = Color.yellow;
        int iEnemy = 0;
        int randomNumbersEnemy = Random.Range(0, 6);
        int previousnumberEnemy = randomNumbersEnemy;

        while (iEnemy < 7)
        {
            if (iEnemy >= 1 && randomNumbersEnemy == previousnumberEnemy)
            {
                while (randomNumbersEnemy == previousnumberEnemy)
                {
                    randomNumbersEnemy = Random.Range(0, 6);
                }
            }
            previousnumberEnemy = randomNumbersEnemy;

            yield return new WaitForSeconds(0.2f);


            Debug.Log(randomNumbersEnemy);
            sprite2.sprite = spriteArray[randomNumbersEnemy];
            iEnemy++;

            randomNumbersEnemy = Random.Range(0, 6);

        }
        iEnemy = 0;
        while (iEnemy < 4)
        {
            if (randomNumbersEnemy == previousnumberEnemy)
            {
                while (randomNumbersEnemy == previousnumberEnemy)
                {
                    randomNumbersEnemy = Random.Range(0, 6);
                }
            }
            previousnumberEnemy = randomNumbersEnemy;

            yield return new WaitForSeconds(0.5f);


            Debug.Log(randomNumbersEnemy);
            sprite2.sprite = spriteArray[randomNumbersEnemy];
            enemyScore = randomNumbersEnemy;
            iEnemy++;
            if (iEnemy < 4)
            {
                randomNumbersEnemy = Random.Range(0, 6);
            }
        }
        sprite2.color = Color.red;
        Debug.Log("KONIEC");
        yield return new WaitForSeconds(1f);
        Debug.Log($"Wynik bota to: {enemyScore}");
        CompareResults();
    }

    public int ShowPLayerScore()
    {
        return playerScore;
    }

    public int ShowEnemyScore()
    {
        return enemyScore;
    }


}
