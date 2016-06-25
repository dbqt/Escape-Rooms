using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float rotateSpeed;
    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;

    // Use this for initialization
    void Start() {

        moveHorizontal = 0;
        moveVertical = 0;

    }

    // Update is called once per frame
    void Update() {

        
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

        //Debug.Log("Vertical : " + moveVertical);
        //Debug.Log("Horizontal : " + moveHorizontal);

        if (moveVertical != 0.0)
        {

            
            movement.z = moveVertical;
            transform.Translate(movement * (speed * Time.deltaTime));


        }
        if (moveHorizontal >= 0.02 ||  moveHorizontal <= -0.02)
        {
          
            transform.Rotate(new Vector3(0.0f, rotateSpeed * Mathf.Sign(moveHorizontal), 0.0f));
            
          
        }
      


    }
}
