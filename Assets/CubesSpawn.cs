using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubesSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject cube;
    public GameObject prefab;
    void Start()
    {
        // GameObject Instance
        // Move object by zero
        //gameObject.transform.Translate(Vector3.zero);

        // Declarction
        GameObject cube;
        GameObject newObject;

        // Game Object Class
        //cube = GameObject.CreatePrimitive(PrimitiveType.Cube); // Creates and returns

        // For Spawning in Objects
        newObject = GameObject.Instantiate(prefab); // Adds the Prefab on the inspector in Unity
        newObject = GameObject.CreatePrimitive(PrimitiveType.Cube); // Creates the Cube
        newObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red); // Changes the color of the cube
        newObject.AddComponent<Rigidbody>(); // Add the Physics to the Cube
                                                    

        // Change the color of the cube
        //cube.GetComponent<Renderer>().material.SetColor("_Color" , Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
