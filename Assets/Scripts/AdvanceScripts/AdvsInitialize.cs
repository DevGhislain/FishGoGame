using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdvsInitialize : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    #region Accesor game

    /// <summary>
    /// Reference for the android Game Id
    /// </summary>
    [SerializeField]
    string _androidGameId;

    /// <summary>
    /// Reference for the IOS Game Id
    /// </summary>
    [SerializeField]
    string _iOSGameId;

    /// <summary>
    /// reference for the test mode
    /// </summary>
    [SerializeField]
    bool _testMode = true;

    /// <summary>
    /// reference for the game id in game
    /// </summary>
    string gameId;

    #endregion

    #region Unity methods

    /// <summary>
    /// init the game
    /// </summary>
    private void Awake()
    {
        if (Advertisement.isInitialized)
        {
            Debug.Log("Advertissement is initialized");
            //LoadedRewardedAd();
            LoadInerstitialAd();
        }
        else
        {
            InitializeAds();
        }
       
    }

    #endregion

    #region Public methods

    /// <summary>
    /// Methods for the init the ads service 
    /// /// </summary>
    public void InitializeAds()
    {
        gameId = (Application.platform == RuntimePlatform.IPhonePlayer) ? _iOSGameId : _androidGameId;
        Advertisement.Initialize(gameId, _testMode, this);
    }

    /// <summary>
    /// Methods for on the Initialization Complete
    /// </summary>
    public void OnInitializationComplete()
    {
        Debug.Log("On Initialization Complete");
        LoadInerstitialAd();
        LoadBannerAd();
    }

    /// <summary>
    /// Methods for On the Initialization Failed
    /// </summary>
    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log("On Initialization Failed ");
        InitializeAds();
    }

    /// <summary>
    /// Methods for the Load Inerstitial Ad
    /// </summary>
    public void LoadInerstitialAd()
    {
        Advertisement.Load("Interstitial_Android", this);
    }

    #region Rewaded video ads

    /// <summary>
    /// Method for the Loaded Rewarded
    /// </summary>
    public void LoadedRewardedAd()
    {
        Advertisement.Load("Rewarded_Android)", this);
    }

    #endregion


    /// <summary>
    /// Methods for the Unity Ads AdLoaded
    /// </summary>
    public void OnUnityAdsAdLoaded(string placementId)
    {
        Advertisement.Show(placementId, this);
    }

    /// <summary>
    /// Methods for the Unity Ads AdLoaded
    /// </summary>
    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        Debug.Log("On UnityAds Failed ToLoad");
    }

    /// <summary>
    /// Methods for the Unity Ads Show Failure
    /// </summary>
    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        Debug.Log("On UnityAds Show Failure");
    }

    /// <summary>
    /// Methods for the Unity Ads Show Start
    /// </summary>
    public void OnUnityAdsShowStart(string placementId)
    {
        Debug.Log("On UnityAds Show Start");
        Time.timeScale = 0;
        Advertisement.Banner.Hide();
    }

    /// <summary>
    /// Methods for the Unity Ads Show Click
    /// </summary>
    public void OnUnityAdsShowClick(string placementId)
    {
        Debug.Log("On UnityAds Show Click");
    }

    /// <summary>
    /// Methods for the Unity Ads Show Complete
    /// </summary>
    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        Debug.Log("On UnityAdsShow Complete"+ showCompletionState);
        Time.timeScale = 1;
        Advertisement.Banner.Show("Banner_Android");
    }

    #endregion

    #region Banner Ads

    public void LoadBannerAd()
    {
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        Advertisement.Banner.Load("Banner_Android", new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnbannerError
        });
    }

    /// <summary>
    /// Methods of Banner loaded 
    /// </summary>
    void OnBannerLoaded()
    {
        Advertisement.Banner.Show("Banner_Android");
    }

    /// <summary>
    /// Methods of banner error
    /// </summary>
    /// <param name="_message"></param>
    void OnbannerError( string _message)
    {

    }

    #endregion
}

