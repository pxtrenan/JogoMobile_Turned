using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Death : MonoBehaviour
{
    public GameObject ball;
    public GameObject canvasGameOver;

    public void ShowInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD XXX");
        }
    }

    void Start()
    {
        RequestInterstitialAds();
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Glass")
        {
            ball.gameObject.SetActive(false);
            canvasGameOver.gameObject.SetActive(true);
           

            ShowInterstitialAd();

        }
    }

    InterstitialAd interstitial;
    private void RequestInterstitialAds()
    {
        string adID = "ca-app-pub-3526702404345714/3858406034";

#if UNITY_ANDROID
        string adUnitId = adID;
#elif UNITY_IOS
        string adUnitId = adID;
#else
        string adUnitId = adID;
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //***Test***
        AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
       .Build();

        //***Production***
        //AdRequest request = new AdRequest.Builder().Build();

        //Register Ad Close Event
        interstitial.OnAdClosed += Interstitial_OnAdClosed;

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("AD LOADED XXX");

    }
    //Ad Close Event
    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        //Resume Play Sound

    }

}
