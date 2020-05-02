using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30f; //for sandwich
    private float lowerBound = -10f; //for animals
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //int noOfAnimalsFedInConsole = 0;

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //noOfAnimalsFedInConsole = noOfAnimalsFedInConsole + 1;
            //Debug.Log("Total no of animals fed into console is " + noOfAnimalsFedInConsole);
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
