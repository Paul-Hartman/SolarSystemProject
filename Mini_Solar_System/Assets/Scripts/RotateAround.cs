using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target; //object to rotate around
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("Rotate around target not specified. defaulting to parent Game Object");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
