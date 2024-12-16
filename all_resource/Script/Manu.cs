using UnityEngine;
using UnityEngine.SceneManagement;

public class Manu : MonoBehaviour
{
    public void StatScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
