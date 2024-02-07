//using system 
using System.Collections;
using System.Collections.Generic;

// Using Unity 
using UnityEngine;

//Usong Playfabs
using PlayFab;
using PlayFab.ClientModels;

/// <summary>
/// Class for the Manage the playfabs
/// </summary>
public class PlayfabsManager : MonoBehaviour
{

    /// <summary>
    /// 
    /// </summary>
    public static int bestvalueAccount;

    // Start is called before the first frame update
    void Start()
    {
        Login();
    }

    #region Private Methods


    /// <summary>
    /// methods for the login
    /// </summary>
    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
    }
     
    /// <summary>
    /// Methods On Success 
    /// </summary>
    /// <param name="result"></param>
    void OnSuccess(LoginResult result)
    {
        Debug.Log("Sucessful login / account create !");
    }

    /// <summary>
    /// Methods on error 
    /// </summary>
    /// <param name="error"></param>
    void OnError(PlayFabError error)
    {
        Debug.Log("Error while logging in/creating account");
        Debug.Log(error.GenerateErrorReport());
    }


    /// <summary>
    /// Methods for the leader board Update
    /// </summary>
    /// <param name="result"></param>
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("SuccessFull leaderboard sent");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="result"></param>
    void OnLeaderBoardGet(GetLeaderboardResult result)
    {
        foreach (var item in result.Leaderboard)
        {
            Debug.Log(item.Position + " " + item.DisplayName + " " + item.PlayFabId + " " + item.StatValue);
        };
    }


    #endregion

    #region Public Methods

    /// <summary>
    /// Method for the send the LeaderBoard      
    /// </summary>
    /// <param name="score"></param>
    public void SendLeaderBoard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName = "PlatformScore",
                    Value = score,
                }
            }
        };

        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }

    /// <summary>
    /// Method for the Get LearderBoard
    /// </summary>
    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "PlatformScore",
            StartPosition = 0,
            MaxResultsCount = 10
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderBoardGet, OnError);
    }



    #endregion
}
