using System;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.OnScoreEvent += UpdateCoins;
    }

    private void UpdateCoins(int coins)
    {
        //Save coins data in a struct or class 
        SaveData();
        GameManager.Instance.OnScoreEvent -= UpdateCoins;
    }
    
    public void SaveData()
    {
        Debug.Log("Save player data");
    }

    public void OnDestroy()
    {
        GameManager.Instance.OnScoreEvent -= UpdateCoins;
    }
}
