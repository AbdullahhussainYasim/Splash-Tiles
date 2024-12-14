using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class bannerAds2 : MonoBehaviour
{

    BannerView bannerView;
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        bannerView = new BannerView("ca-app-pub-3940256099942544/6300978111", AdSize.Banner, AdPosition.Top);
        var adRequest = new AdRequest();
        bannerView.LoadAd(adRequest);

    }

    private void OnDestroy()
    {

        if (bannerView != null)
        {
            bannerView.Destroy();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
