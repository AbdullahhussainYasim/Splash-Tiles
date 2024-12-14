//using GoogleMobileAds.Api;
//using UnityEngine;

//public class AdManager : MonoBehaviour
//{
//    private RewardedAd rewardedAd;
//    public static AdManager Instance; // Singleton for easy access

//    private void Awake()
//    {
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(gameObject); // Persist across scenes
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    private void Start()
//    {
//        MobileAds.Initialize(initStatus => { });
//        LoadRewardedAd();
//    }

//    private void LoadRewardedAd()
//    {
//        string adUnitId = "ca-app-pub-3940256099942544/5224354917"; // Test ID

//        rewardedAd = new RewardedAd(adUnitId);

//        AdRequest adRequest = new AdRequest.Builder().Build();
//        rewardedAd.LoadAd(adRequest);

//        rewardedAd.OnAdLoaded += () => Debug.Log("Rewarded ad loaded.");
//        rewardedAd.OnAdFailedToLoad += (error) => Debug.LogError("Failed to load rewarded ad: " + error);
//        rewardedAd.OnAdClosed += (sender, args) => LoadRewardedAd(); // Reload after showing
//        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
//    }

//    public void ShowRewardedAd()
//    {
//        if (rewardedAd.IsLoaded())
//        {
//            rewardedAd.Show();
//        }
//        else
//        {
//            Debug.LogWarning("Rewarded ad is not ready.");
//        }
//    }

//    private void HandleUserEarnedReward(object sender, Reward args)
//    {
//        Debug.Log("Reward earned: " + args.Amount);
//        GameController.Instance.ResumeGame(); // Resume game after reward
//    }
//}
