using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdsManager : MonoBehaviour
{
#if UNITY_ANDROID
    string gameId = "4576285";
#else
    string gameid = "4576284";
#endif
    // Start is called before the first frame update
    //void Start()
    //{
    //    Advertisement.Initialize(gameId);
    //    Advertisement.AddListener(this);
    //    ShowBanner();
    //}

    //public void PlayAd()
    //{
    //    if(Advertisement.IsReady("Interstitial_Android"))
    //    {
    //        Advertisement.Show("Interstitial_Android");
    //    }
    //}

    //public void PlayRewardedAd()
    //{
    //    if(Advertisement.IsReady("Rewarded_Android"))
    //    {
    //        Advertisement.Show("Rewarded_Android");
    //    }
    //    else
    //    {
    //        Debug.Log("Rewarded ad is not ready!");
    //    }
    //}

    //public void ShowBanner()
    //{
    //    if(Advertisement.IsReady("Banner_Android"))
    //    {
    //        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
    //        Advertisement.Banner.Show("Banner_Android");
    //    }
    //    else
    //    {
    //        StartCoroutine(RepeatShowBanner());
    //    }
    //}

    //IEnumerator RepeatShowBanner()
    //{
    //    yield return new WaitForSeconds(1);
    //    ShowBanner();
    //}

    //public void OnUnityAdsReady(string placementId)
    //{
    //    Debug.Log("ADS ARE READY!");
    //}

    //public void OnUnityAdsDidError(string message)
    //{
    //    Debug.Log("ERROR: " + message);
    //}

    //public void OnUnityAdsDidStart(string placementId)
    //{
    //    Debug.Log("VIDEO START!");
    //}

    //public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    //{
    //    if(placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
    //    {
    //        Debug.Log("PLAYER SHOULD BE REWARDED!");
    //    }
    //}
}
