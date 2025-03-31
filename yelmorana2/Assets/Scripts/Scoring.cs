using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scoring : MonoBehaviour
{
    public static int levelScore = 0;
    public static int totalScore = 0;

    private void Awake()
    {
        // Recuperar la puntuación almacenada al iniciar la escena
        totalScore = PlayerPrefs.GetInt("TotalScore", 0);
        CheckScore();

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckScore()
    {
        if (totalScore > PlayerPrefs.GetInt("totalScore", 0))
        {
            PlayerPrefs.SetInt("totalScore", levelScore);
        }


    }
}
