using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompelete : MonoBehaviour
{
    public void LoadNextlevel()
    {
        Debug.Log("Next Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
