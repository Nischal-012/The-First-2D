using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform look_at;
    public float boundX = 0.15f;
    public float boundY = 0.05f;
    private void LateUpdate()
    {
        Vector3 delta=Vector3.zero;
        float deltaX = look_at.position.x -transform.position.x;
        if(deltaX > boundX ||deltaX < -boundX)
        {
            if (transform.position.x < look_at.position.x)
            {
                delta.x= deltaX-boundX;

            }
            else
            {
                delta.x= deltaX+boundX;
            }
        }
        float deltaY = look_at.position.y -transform.position.y;
        if(deltaY>boundY ||deltaY< -boundY)
        {
            if (transform.position.y < look_at.position.y)
            {
                delta.y= deltaY-boundY;

            }
            else
            {
                delta.y= deltaY+boundY;
            }
        }
        transform.position= transform.position + new Vector3(delta.x,delta.y,0);

    }
}
