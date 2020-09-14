using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyTrasform : MonoBehaviour
{
    public Transform camera;
    public Transform feet;
    public static float hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(camera.position.x, feet.position.y, camera.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
