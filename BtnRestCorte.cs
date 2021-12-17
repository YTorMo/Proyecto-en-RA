using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BtnRestCorte : MonoBehaviour
{
    string ObjName;
    public Button Restablecer;
    // Start is called before the first frame update
    void Start()
    {
        Restablecer.enabled = false;
    }

    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    ObjName = hit.transform.name;
                    if (ObjName == "CorteP1" || ObjName == "CorteP6" || ObjName == "CorteP4-1" || ObjName == "CorteP4-2" || ObjName == "CorteP3-1" || ObjName == "CorteP3-2" || ObjName == "CorteP3-3" || ObjName == "CorteP3-4" || ObjName == "CorteP3-5" || ObjName == "CorteP3-6" || ObjName == "CorteP8-1" || ObjName == "CorteP8-2" ||
                        ObjName == "CorteP4-3" || ObjName == "CorteP2" || ObjName == "CorteP7-1" || ObjName == "CorteP7-2" || ObjName == "CorteP7-3" || ObjName == "CorteP7-4" || ObjName == "CorteP5" || ObjName == "CorteP9y10" || ObjName == "CorteP12" || ObjName == "CorteP11")
                    {
                        Restablecer.enabled = true;
                    }

                }
            }
        }
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    ObjName = hit.transform.name;
                    if (ObjName == "CorteP1" || ObjName == "CorteP6" || ObjName == "CorteP4-1" || ObjName == "CorteP4-2" || ObjName == "CorteP3-1" || ObjName == "CorteP3-2" || ObjName == "CorteP3-3" || ObjName == "CorteP3-4" || ObjName == "CorteP3-5" || ObjName == "CorteP3-6" || ObjName == "CorteP8-1" || ObjName == "CorteP8-2" ||
                        ObjName == "CorteP4-3" || ObjName == "CorteP2" || ObjName == "CorteP7-1" || ObjName == "CorteP7-2" || ObjName == "CorteP7-3" || ObjName == "CorteP7-4" || ObjName == "CorteP5" || ObjName == "CorteP9y10" || ObjName == "CorteP12" || ObjName == "CorteP11")
                    {
                        Restablecer.enabled = true;
                    }

                }
            }
        }
#endif
    }
}