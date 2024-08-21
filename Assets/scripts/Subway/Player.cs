using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
public class Player : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;
    public float speed = 10;
    public bool jumping = false;
    public bool downJumping = false;
    public bool Crouch = false;


    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed,Space.World);      
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 4) 
            {
                 transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
        {
            if (jumping == false) 
            {
                jumping = true;
                player.GetComponent<Animator>().Play("Jump");
                StartCoroutine(Jump());
            }
           
        }
        if (jumping == true)
        {
            if (downJumping == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime *2,Space.World);
            }
            if (downJumping == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -2, Space.World);
            }
        }
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.DownArrow))
        {
            if (Crouch == false)
            {
                Crouch = true;
                StartCoroutine(CrouchMove());
            }
        }
    }

    IEnumerator Jump()
    {
        yield return new WaitForSeconds(0.45f);
        downJumping = true;
        yield return new WaitForSeconds(0.45f);
        jumping = false;
        downJumping = false;
        
        if (player1.GetComponent<Player>().enabled == false)
        {
            player.GetComponent<Animator>().Play("Stumble Backwards");

        }
        else 
        {
            player.GetComponent<Animator>().Play("Standard Run");
        }
    }
    IEnumerator CrouchMove()
    {
        yield return new WaitForSeconds(0.01f);
        player.GetComponent<Animator>().Play("Crouching Idle");
        Crouch = false;
        player1.GetComponent<BoxCollider>().size = new Vector3(1,0,1);
        player1.GetComponent<CharacterController>().height =0.5f ;
        player1.GetComponent<CharacterController>().center = new Vector3(0,-0.2f,0);
        yield return new WaitForSeconds(0.8f);
        player1.GetComponent<CharacterController>().height = 1;
        player1.GetComponent<CharacterController>().center = new Vector3(0, 0, 0);
        player1.GetComponent<BoxCollider>().size = new Vector3(1, 1.5f, 1);
        if (player1.GetComponent<Player>().enabled == false)
        {
            player.GetComponent<Animator>().Play("Stumble Backwards");

        }
        else
        {
            player.GetComponent<Animator>().Play("Standard Run");
        }
    }
}
