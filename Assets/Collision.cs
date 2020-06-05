using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovment movement;
    public Scores scoreUpdate;
    GameObject varGameObject ;
    public GameManager manager;
    Collider myCollider ; 
    // GameObject varGameObject = GameObject.FindWithTag("Player"); //then disable or enable script/component
    void Start()
    {
         varGameObject = GameObject.Find("Player");  // or find with tag 
         myCollider = gameObject.GetComponent<Collider>();
    }
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We Hit 0bstacle!!");
            movement.enabled = false;
            scoreUpdate.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
  
    // void OnCollisionEnter(  Collision collision)
    // {
    //     //  Debug.Log(collision.gameObject.name);
    //     //Check for a match with the specified name on any GameObject that collides with your GameObject
    //     // if (collision.gameObject.name == "MyGameObjectName")
    //     // {
    //     //     //If the GameObject's name matches the one you suggest, output this message in the console
    //     //     Debug.Log("Do something here");
    //     // }

    //     // //Check for a match with the specific tag on any GameObject that collides with your GameObject
    //     // if (collision.gameObject.tag == "MyGameObjectTag")
    //     // {
    //     //     //If the GameObject has the same tag as specified, output this message in the console
    //     //     Debug.Log("Do something else here");
    //     // }
    // }
    // void OnCollisionEnter (Collision collision) // Collision determination   
    //      {       
    //            Debug.Log ("col");// log   
    //       }
}
