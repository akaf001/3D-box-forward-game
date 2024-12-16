using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject _player;
    public Text _scoreText;

    private void Update()
    {
        _scoreText.text=((_player.transform.position.z+42.19)*0.2).ToString("0");
    }

}
