using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float Camerspeed;
    public float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate(){
        if(Target!=null){
            Vector2 newCamPosition = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * Camerspeed);
            float ClampX = Mathf.Clamp(newCamPosition.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y, minY, maxY);
            transform.position = new Vector3(ClampX, ClampY, -10f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
