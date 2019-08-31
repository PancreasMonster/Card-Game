using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class DragObject : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    public bool dragging = false;
    public float smoothTime = 0.055F;
    private Vector3 velocity = Vector3.zero;

    void OnMouseDown()
    {     
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseUp()
    {
        dragging = false;
    }
    void OnMouseDrag()
    {
        if (this.GetComponent<CardRotation>().hand == true)
        {
            dragging = true;
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, mZCoord);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mOffset;
            curPosition.y += 0.4f;
            transform.position = Vector3.SmoothDamp(transform.position, curPosition, ref velocity, smoothTime);
        }
    }
}