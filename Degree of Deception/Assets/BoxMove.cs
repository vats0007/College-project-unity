using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    public Rigidbody rb;
    public float Force;
    public int tick;
    public float tickTimer;
    public const float TICK_TIMER_MAX = 3f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * Time.deltaTime * Force, ForceMode.Impulse);
        }
    }
}
