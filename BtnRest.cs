using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BtnRest : MonoBehaviour
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
                    if (ObjName == "Pieza1"|| ObjName == "Pieza2"|| ObjName == "Pieza4-1" || ObjName == "Pieza4-2" || ObjName == "Pieza3-1" || ObjName == "Pieza3-2" || ObjName == "Pieza3-3" || ObjName == "Pieza3-4" || ObjName == "Pieza3-5" || ObjName == "Pieza3-6" || ObjName == "Pieza8-1" || ObjName == "Pieza8-2" ||
                        ObjName == "Pieza4-3" || ObjName == "Pieza6" || ObjName == "Pieza7-1" || ObjName == "Pieza7-2" || ObjName == "Pieza7-3" || ObjName == "Pieza7-4" || ObjName == "Pieza5" || ObjName == "Pieza9y10" || ObjName == "Pieza12" || ObjName == "Pieza11")
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
                    if (ObjName == "Pieza1" || ObjName == "Pieza2" || ObjName == "Pieza4-1" || ObjName == "Pieza4-2" || ObjName == "Pieza3-1" || ObjName == "Pieza3-2" || ObjName == "Pieza3-3" || ObjName == "Pieza3-4" || ObjName == "Pieza3-5" || ObjName == "Pieza3-6" || ObjName == "Pieza8-1" || ObjName == "Pieza8-2" ||
                        ObjName == "Pieza4-3" || ObjName == "Pieza6" || ObjName == "Pieza7-1" || ObjName == "Pieza7-2" || ObjName == "Pieza7-3" || ObjName == "Pieza7-4" || ObjName == "Pieza5" || ObjName == "Pieza9y10" || ObjName == "Pieza12" || ObjName == "Pieza11")
                    {
                        Restablecer.enabled = true;
                    }

                }
            }
        }
#endif
    }
}
