using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public static int loadedCoins;
    public static int loadedGems;
    public static int loadedDistance;

    public static bool saveData;

    [SerializeField] int internalCoin;
    [SerializeField] int internalGem;
    [SerializeField] int internalDistance;

    void Start()
    {
        loadedCoins = PlayerPrefs.GetInt("COINSAVE");
        loadedGems = PlayerPrefs.GetInt("GEMSAVE");
        loadedDistance = PlayerPrefs.GetInt("DISTANCESAVE");
    }

    // Update is called once per frame
    void Update()
    {
        internalCoin = loadedCoins + MasterInfo.coinCount;
        internalGem = loadedGems + MasterInfo.gemCount;
        internalDistance = loadedDistance + MasterInfo.distanceRun;
        if (saveData == true)
        {
            saveData = false;
            PlayerPrefs.SetInt("COINSAVE", internalCoin);
            PlayerPrefs.SetInt("GEMSAVE", internalGem);
            PlayerPrefs.SetInt("DISTANCESAVE", internalDistance);
        }
    }
}
