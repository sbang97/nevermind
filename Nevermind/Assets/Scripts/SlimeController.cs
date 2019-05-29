using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D myRigidBody;

    private bool moving;

    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private float timeToMoveCounter;

    private Vector3 moveDirection;

    public float waitToReload;
    public bool reloading;
    private GameObject thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();

        timeBetweenMoveCounter = Random.Range(timeBetweenMove * .75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMove * 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            timeToMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = moveDirection;

            if (timeToMoveCounter < 0f)
            {
                moving = false;
                timeBetweenMoveCounter = Random.Range(timeBetweenMove * .75f, timeBetweenMove * 1.25f);
            }
        } else
        {
            timeBetweenMoveCounter -= Time.deltaTime;
            myRigidBody.velocity = Vector2.zero;

            if (timeBetweenMoveCounter < 0f)
            {
                moving = true;
                timeToMoveCounter = Random.Range(timeToMove * .75f, timeBetweenMove * 1.25f); 
                moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
            }
        }
        /*
        if (reloading)
        {
            waitToReload -= Time.deltaTime;
            if (waitToReload < 0)
            {
                //deprecated now Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                thePlayer.SetActive(true);
            }
        }
        */
    }
    /*
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.SetActive(false);
            reloading = true;
            thePlayer = other.gameObject;
        }
    }
    */

}
