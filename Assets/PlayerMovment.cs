using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Start is called before the first frame update
	public Rigidbody rb;
    public Scores scoreUpdate;
	public float forwardForce = 2000f;
	public float sideWayForce = 500f;
    void Start()
    {
        Debug.Log("Hello, World");
    }

    // Update is called once per frame
    void Update()
    {
      //  rb.AddForce(0,0,2000 * Time.deltaTime );
    }
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime );
	    if(Input.GetKey("d"))
	    {
	      rb.AddForce(sideWayForce*Time.deltaTime,0, 0 , ForceMode.VelocityChange);
	    }
	    if(Input.GetKey("a"))
	    {
	       rb.AddForce(-1*sideWayForce*Time.deltaTime,0, 0, ForceMode.VelocityChange);
	    }
        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
            scoreUpdate.enabled = false;
        }
    }
}
