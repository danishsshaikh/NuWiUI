using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberCON : MonoBehaviour
{
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI ehGuess;
    int guess;
    void Start()
    {
        StartGame();       
    }

    void StartGame()
    {
        NextGuess();
        //max = max + 1;
    }

    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max);
        ehGuess.text = guess.ToString();
    }

    public void OnPressLower()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressHigher()
    {
        max = guess;
        NextGuess();
    }

}
