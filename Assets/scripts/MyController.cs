using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
    public float speed = 2.0f;
   // private Rigidbody rb;

    //Vector3 input;
    //public GameObject go;
    private CharacterController mController;
    public float gravity = 9.8f;
    
    // Start is called before the first frame update
    void Start()
    {
        mController = this.gameObject.GetComponent<CharacterController>();
        

     //   rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movX = Input.GetAxis("Horizontal") * Vector3.right * speed;
        Vector3 movZ = Input.GetAxis("Vertical") * Vector3.forward * speed;
        Vector3 mov=transform.TransformDirection(movX+movZ);
        mov.y -= gravity * Time.deltaTime;

        mController.Move(mov);
        


    }
}
