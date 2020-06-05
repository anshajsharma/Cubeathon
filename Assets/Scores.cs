using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public Transform player;
    public Text ScoresText;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);
        ScoresText.text = "Score:" + player.position.z.ToString("0");
    }
}
