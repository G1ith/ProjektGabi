using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 5.0f;
    void Update()
    {   // forward
        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
