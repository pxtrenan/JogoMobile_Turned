using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour
{
    InterstitialAd interstitial;

    // Use this for initialization
    void Start()
    {
        //Request Ads
        RequestBanner();
        RequestInterstitial();
    }

    public void ShowInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
            Debug.Log("anuncio");
        }

    }


    private void RequestBanner()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3526702404345714/2670157883";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the bottom of the screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3526702404345714/3858406034";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

}