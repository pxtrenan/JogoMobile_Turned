using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public static LevelManager levelManager;


    private int pontosAtual = 0;

    public Text score;
    public Text score2;
    public Text score22;
    public Text highScore;
    public Text highScore2;

    public AudioClip soundPoint;
    public AudioSource somBall;


    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        highScore2.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Awake()
    {
        // somPlayer.ignoreListenerPause = true;

        if (levelManager == null)
        {
            levelManager = this;
        }
        else if (levelManager != this)
        {
            Destroy(gameObject);
        }

    }

    public void SetScore()
    {
        pontosAtual++;
        score.text = pontosAtual.ToString();
        score2.text = pontosAtual.ToString();
        score22.text = pontosAtual.ToString();
        somBall.PlayOneShot(soundPoint);
        
        
        if (pontosAtual > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", pontosAtual);


        }
    }
    public int GetScore()
    {
        return pontosAtual;
    }


    //Update is called once per frame
    void Update()
    {

    }
}
