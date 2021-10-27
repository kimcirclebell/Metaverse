using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target;
    public float cameraSpeed = 10.0f;
    private Vector3 targetPosition;

    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //x +- 10, y +- 13
        if(target != null)
        {
            x = target.transform.position.x;
            y = target.transform.position.y;
            if (x > 10.0f) x = 10.0f;
            else if (x < -10.0f) x = -10.0f;

            if (y > 13.0f) y = 13.0f;
            if (y < -13.0f) y = -13.0f;



            targetPosition.Set(x, y, this.transform.position.z);

            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, cameraSpeed * Time.deltaTime);

        }
    }
}
