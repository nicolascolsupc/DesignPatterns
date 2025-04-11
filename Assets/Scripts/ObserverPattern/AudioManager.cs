using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private void Start()
    {
        GameManager.Instance.OnScoreEvent += PlayCoinSound;
    }

    private void PlayCoinSound(int coin)
    {
        Play("Coin");
    }
    private void Play(string soundId)
    {
        Debug.Log($"Play Sound: {soundId}");
    }
    
    public void OnDestroy()
    {
        GameManager.Instance.OnScoreEvent -= PlayCoinSound;
    }
}
