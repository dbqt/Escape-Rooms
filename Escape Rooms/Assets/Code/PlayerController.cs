using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float rotateSpeed;
    public float jumpStrength;
    private bool isJumping;
    private float prevJumpVelocity;
    private Vector3 jumpForce;
    
    
    // Use this for initialization
    void Start() 
    {
        isJumping = false;
        prevJumpVelocity = 0;
        jumpForce = new Vector3(0, jumpStrength, 0);
    }

    // Update is called once per frame
    void Update()
     {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);
        

        //Debug.Log("Vertical : " + moveVertical);
        //Debug.Log("Horizontal : " + moveHorizontal);
       
        if(Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (isJumping == false) Jump();
            else if ((GetComponent<Rigidbody>().velocity.y - prevJumpVelocity) != 0)
                isJumping = false;
          
            
        }
       

        Debug.Log("Vertical : " + moveVertical);
        Debug.Log("Horizontal : " + moveHorizontal);

        if (moveVertical != 0.0)
        {


            movement.z = moveVertical * (-1);
            transform.Translate(movement * (speed * Time.deltaTime));

       

    }
        if (moveHorizontal >= 0.02 || moveHorizontal <= -0.02)
        {

            transform.Rotate(new Vector3(0.0f, rotateSpeed * Mathf.Sign(moveHorizontal), 0.0f));


        }

      

    }
    void FixedUpdate()
    {
       // float changeForce = 
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger enter with "+other.gameObject.name);
        if(other.gameObject.tag == "Exit")
        {
            GameManager.instance.EndLevel(true);
        }
        if(other.gameObject.tag == "Trap")
        {
            GameManager.instance.RedoLevel();
        }
    }
    
    void Jump()
    {
        isJumping = true;
        
        
        GetComponent<Rigidbody>().AddForce(jumpForce);
        prevJumpVelocity = GetComponent<Rigidbody>().velocity.y;

    }

}
