using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float rotateSpeed;
    private bool isJumping;

    // Use this for initialization
    void Start() 
    {
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
     { 
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

        //Debug.Log("Vertical : " + moveVertical);
        //Debug.Log("Horizontal : " + moveHorizontal);

        if (moveVertical != 0.0)    
        {      
            movement.z = moveVertical;
            transform.Translate(-movement * (speed * Time.deltaTime));
            if(!this.gameObject.GetComponents<AudioSource>()[0].isPlaying)
            {
                this.gameObject.GetComponents<AudioSource>()[0].Play();
            }
        }
        else
        {
            this.gameObject.GetComponents<AudioSource>()[0].Stop();
        }


        if (moveHorizontal >= 0.02 ||  moveHorizontal <= -0.02)
        {
            transform.Rotate(new Vector3(0.0f, rotateSpeed * Time.deltaTime * Mathf.Sign(moveHorizontal), 0.0f));      
        }
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
}
