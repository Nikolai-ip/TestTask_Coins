using UnityEngine;

public class CoinAudioController : MonoBehaviour
{
    private AudioSource _takeCoinSound;
    private void Start()
    {
        _takeCoinSound = GetComponent<AudioSource>();
    }
    public void PlayTakeCoinSound() => _takeCoinSound.Play();

}
