using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] private GameManagerscript _gameManager;

    private void OnTriggerEnter(Collider other)
    {
        _gameManager.completeLevel();
    }
}
