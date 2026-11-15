using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomainmenu : MonoBehaviour
{
    public void BackToLevelSelector()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
