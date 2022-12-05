using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject muteButton;
    public GameObject desmuteButton;

    public GameObject hh;
    public GameObject ss;
    public GameObject mvp;

    public string ANDROID_OTHER_URL = "market://details?id=com.ra.HorizonHill";
    public string ANDROID_OTHER2_URL = "market://details?id=com.ra.StarScraper";
    public string ANDROID_OTHER3_URL = "market://details?id=com.ra.MVPChallenge";

    private int cena;

    private int temp = 0;

    public void PressedButtonHH()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }
    public void PressedButtonSS()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER2_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }
    public void PressedButtonMVP()
    {
#if UNITY_ANDROID
        Application.OpenURL(ANDROID_OTHER3_URL);
        Debug.Log("Rate on Android");
#elif UNITY_IOS
        Application.OpenURL(IOS_RATE_URL);
                Debug.Log("Rate on Iphone");
#endif
    }

    public void PlayButton ()
    {
        SceneManager.LoadScene("Jogo1");
    }

    public void MuteButton()
    {
        AudioListener.pause = true;
        if (AudioListener.pause)
        {
            muteButton.gameObject.SetActive(false);
            desmuteButton.gameObject.SetActive(true);

            DontDestroyOnLoad(gameObject);
        }
    }

    public void MoreGames()
    {
        hh.gameObject.SetActive(true);
        ss.gameObject.SetActive(true);
        mvp.gameObject.SetActive(true);
    }

    public void DesmuteButton()
    {
        AudioListener.pause = true;
        if (AudioListener.pause)
        {
            desmuteButton.gameObject.SetActive(false);
            muteButton.gameObject.SetActive(true);

            DontDestroyOnLoad(gameObject);
        }
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void CarregarLevel(string nomeLevel)
    {

        cena = Random.Range(1, 8);
        Debug.Log(cena);

        while (temp == cena)
        {
            cena = Random.Range(1, 6);
        }

        temp = cena;

        switch (cena)
        {
            case 1:
                SceneManager.LoadScene("Jogo1");
                break;
            case 2:
                SceneManager.LoadScene("Jogo2");
                break;
            case 3:
                SceneManager.LoadScene("Jogo3");
                break;
            case 4:
                SceneManager.LoadScene("Jogo4");
                break;
            case 5:
                SceneManager.LoadScene("Jogo5");
                break;
          
        }
    }

}
