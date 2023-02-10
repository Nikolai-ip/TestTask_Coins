using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject _winText;
    [SerializeField] private GameObject _scoreText;
    [SerializeField] private float _timeForReload;
    private void Start()
    {
        _winText.SetActive(false);
    }
    public void Win()
    {
        _winText.SetActive(true);
        _scoreText.SetActive(false);
        ReloadSceneWithDelay();
    }
    private async void ReloadSceneWithDelay()
    {
        await Task.Delay((int)_timeForReload * 1000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
