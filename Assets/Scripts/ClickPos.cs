using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPos : MonoBehaviour
{
    public LayerMask clickMask;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = -Vector3.one;
            Ray raybeam = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            if (Physics.Raycast(raybeam, out RaycastHit hit))
            {
                clickPosition = hit.point;
            }
            Debug.Log(clickPosition);
        }

    }
}
