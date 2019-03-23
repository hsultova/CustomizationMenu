using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void SceneTransition()
    {
        SceneManager.LoadScene("Game");
    }
}
