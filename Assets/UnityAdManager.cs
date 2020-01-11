using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdManager : MonoBehaviour
{

    public static UnityAdManager instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowAd()
    {
        if (PlayerPrefs.HasKey("Adcount"))
        {
            if (PlayerPrefs.GetInt("Adcount") == 3)
            {
                //show Ad

                if (Advertisement.IsReady("IntegrationIDFromPlatformWithAdd"))
                {
                    Advertisement.Show("IntegrationIDFromPlatformWithAdd");
                }
                PlayerPrefs.SetInt("Adcount", 0);
            }
            else
            {
                PlayerPrefs.SetInt("Adcount", PlayerPrefs.GetInt("Adcouunt") + 1);
            }
        }
        else
        {
            PlayerPrefs.SetInt("Adcount", 0);
        }

    }
}
