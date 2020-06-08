using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpawner : MonoBehaviour
{
    public GameObject UIElement;


    void start() { }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Time.timeScale == 1.0f)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = new Vector3(touch.position.x, touch.position.y, 0);
            Ray ray = Camera.main.ScreenPointToRay(touchPosition);
            RaycastHit hitResult;
            Physics.Raycast(ray, out hitResult);
            Vector3 textPos = hitResult.point;
            if (touch.phase == TouchPhase.Began)
                Instantiate(UIElement, textPos, Quaternion.identity);
        }
    }
}
