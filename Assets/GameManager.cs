using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public PlayerMovment movement;
    public Scores scoreUpdate;
    public float restartDeley = 3f;
    public GameObject completeLevelUi;
    public void CompleteLevel()
    {
        Debug.Log("Level compeleted");
        completeLevelUi.SetActive(true);
        scoreUpdate.enabled = false;
    }

   public void EndGame()
   {
       if(gameEnded==false){
           gameEnded=true;
           Debug.Log("Game Over");
           Invoke("RestartGame",restartDeley);
       }
   }
   public void RestartGame()
   {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           gameEnded=false;
           movement.enabled = true;
           scoreUpdate.enabled = true;
           Debug.Log("Game Restarted");
   }

}
