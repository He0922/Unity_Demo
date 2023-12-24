using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Location : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MouseLocation = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(MouseLocation);
    }
}
