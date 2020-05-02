using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10f;

    public GameObject[] projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keep the player in bound, within boundary
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        int foodIndex = Random.Range(0, projectilePrefab.Length);
        if (Input.GetKeyDown(KeyCode.Space)){
            //launch projectile from player
            Instantiate(projectilePrefab[foodIndex],transform.position,projectilePrefab[foodIndex].transform.rotation);
        }
    }
}
