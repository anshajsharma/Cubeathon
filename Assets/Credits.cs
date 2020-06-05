using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit(){
        Debug.Log("Quitted");
        Application.Quit();
    }
    public void StratGame(){
        Debug.Log("Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
