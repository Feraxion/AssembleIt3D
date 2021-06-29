using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DraggableObject : MonoBehaviour
{
    float zZposition;
    Vector3 offSet;
    Camera mainCamera;
    bool dragging;

    [SerializeField]
    public UnityEvent onBeginDrag;
    [SerializeField]
    public UnityEvent onEndDrag;

    void Start()
    {
        mainCamera = Camera.main;
        zZposition = mainCamera.WorldToScreenPoint(transform.position).z;
    }
    void Update()
    {
        if (dragging)
        {
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zZposition);
            transform.position = mainCamera.ScreenToWorldPoint(position + new Vector3(offSet.x, offSet.y));
        }
    }

    void OnMouseDown()
    {
        if (!dragging)
        {
            BeginDrag();
        }
    }

    void OnMouseUp()
    {
        EndDrag();
    }



    public void BeginDrag()
    {
        onBeginDrag.Invoke();
        dragging = true;
        offSet = mainCamera.WorldToScreenPoint(transform.position) - Input.mousePosition;
    }

    public void EndDrag()
    {
        onEndDrag.Invoke();
        dragging = false;
    }
}
