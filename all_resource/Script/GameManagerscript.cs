using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerscript : MonoBehaviour
{
    private bool _gameEnded = false;
    [SerializeField] private float _delay = 2f;

    public GameObject _completeLevelUI;

    public void EndGame()
    {
        if (_gameEnded == false)
        {
            _gameEnded = true;
            Debug.Log("game over");
            
            Invoke("RestartGame", _delay);
        } 

    }

    public void completeLevel()
    {
        _completeLevelUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}
