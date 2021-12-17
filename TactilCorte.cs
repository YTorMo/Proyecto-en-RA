using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class TactilCorte : MonoBehaviour
{


    string ObjName;
    public Animator anim;
    private Text Nombre;




    private void Start()
    {
        Nombre = GameObject.Find("Texto").GetComponent<Text>();
        Nombre.text = "";
       
    }

    // Update is called once per frame
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

                    switch (ObjName)
                    {
                        case "CorteP1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP1A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1R"))
                            {
                                anim.Play("CP1A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1A"))
                            {
                                anim.Play("CP1R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP2A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP2R"))
                            {
                                anim.Play("CP2A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP2A"))
                            {
                                anim.Play("CP2R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP4-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP31A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP31R"))
                            {
                                anim.Play("CP31A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP31A"))
                            {
                                anim.Play("CP31R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP4-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP32A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP32R"))
                            {
                                anim.Play("CP32A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP32A"))
                            {
                                anim.Play("CP32R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP41A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP41R"))
                            {
                                anim.Play("CP41A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP41A"))
                            {
                                anim.Play("CP41R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP42A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP42R"))
                            {
                                anim.Play("CP42A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP42A"))
                            {
                                anim.Play("CP42R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP43A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP43R"))
                            {
                                anim.Play("CP43A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP43A"))
                            {
                                anim.Play("CP43R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-4":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP44A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP44R"))
                            {
                                anim.Play("CP44A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP44A"))
                            {
                                anim.Play("CP44R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP45A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP45R"))
                            {
                                anim.Play("CP45A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP45A"))
                            {
                                anim.Play("CP45R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP46A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP46R"))
                            {
                                anim.Play("CP46A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP46A"))
                            {
                                anim.Play("CP46R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP8-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP51A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP51R"))
                            {
                                anim.Play("CP51A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP51A"))
                            {
                                anim.Play("CP51R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP8-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP52A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP52R"))
                            {
                                anim.Play("CP52A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP52A"))
                            {
                                anim.Play("CP52R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP4-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP6A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP6R"))
                            {
                                anim.Play("CP6A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP6A"))
                            {
                                anim.Play("CP6R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP7A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP7R"))
                            {
                                anim.Play("CP7A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP7A"))
                            {
                                anim.Play("CP7R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP7-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP81A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP81R"))
                            {
                                anim.Play("CP81A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP81A"))
                            {
                                anim.Play("CP81R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP7-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP82A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP82R"))
                            {
                                anim.Play("CP82A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP82A"))
                            {
                                anim.Play("CP82R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP7-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP83A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP83R"))
                            {
                                anim.Play("CP83A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP83A"))
                            {
                                anim.Play("CP83R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP9A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP9R"))
                            {
                                anim.Play("CP9A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP9A"))
                            {
                                anim.Play("CP9R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP9y10":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP1011A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1011R"))
                            {
                                anim.Play("CP1011A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1011A"))
                            {
                                anim.Play("CP1011R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP12":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP12A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP12R"))
                            {
                                anim.Play("CP12A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP12A"))
                            {
                                anim.Play("CP12R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP11":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP13A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP13R"))
                            {
                                anim.Play("CP13A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP13A"))
                            {
                                anim.Play("CP13R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        default:

                            Nombre.text = "";
                            break;
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

                    switch (ObjName)
                    {
                        case "CorteP1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP1A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1R"))
                            {
                                anim.Play("CP1A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1A"))
                            {
                                anim.Play("CP1R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP2A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP2R"))
                            {
                                anim.Play("CP2A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP2A"))
                            {
                                anim.Play("CP2R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP4-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP31A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP31R"))
                            {
                                anim.Play("CP31A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP31A"))
                            {
                                anim.Play("CP31R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP4-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP32A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP32R"))
                            {
                                anim.Play("CP32A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP32A"))
                            {
                                anim.Play("CP32R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP41A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP41R"))
                            {
                                anim.Play("CP41A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP41A"))
                            {
                                anim.Play("CP41R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP42A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP42R"))
                            {
                                anim.Play("CP42A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP42A"))
                            {
                                anim.Play("CP42R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP43A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP43R"))
                            {
                                anim.Play("CP43A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP43A"))
                            {
                                anim.Play("CP43R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-4":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP44A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP44R"))
                            {
                                anim.Play("CP44A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP44A"))
                            {
                                anim.Play("CP44R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP45A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP45R"))
                            {
                                anim.Play("CP45A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP45A"))
                            {
                                anim.Play("CP45R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP3-6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP46A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP46R"))
                            {
                                anim.Play("CP46A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP46A"))
                            {
                                anim.Play("CP46R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP8-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP51A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP51R"))
                            {
                                anim.Play("CP51A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP51A"))
                            {
                                anim.Play("CP51R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP8-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP52A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP52R"))
                            {
                                anim.Play("CP52A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP52A"))
                            {
                                anim.Play("CP52R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP4-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP6A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP6R"))
                            {
                                anim.Play("CP6A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP6A"))
                            {
                                anim.Play("CP6R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP7A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP7R"))
                            {
                                anim.Play("CP7A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP7A"))
                            {
                                anim.Play("CP7R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP7-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP81A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP81R"))
                            {
                                anim.Play("CP81A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP81A"))
                            {
                                anim.Play("CP81R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP7-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP82A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP82R"))
                            {
                                anim.Play("CP82A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP82A"))
                            {
                                anim.Play("CP82R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP7-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP83A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP83R"))
                            {
                                anim.Play("CP83A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP83A"))
                            {
                                anim.Play("CP83R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP9A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP9R"))
                            {
                                anim.Play("CP9A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP9A"))
                            {
                                anim.Play("CP9R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP9y10":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP1011A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1011R"))
                            {
                                anim.Play("CP1011A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP1011A"))
                            {
                                anim.Play("CP1011R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP12":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP12A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP12R"))
                            {
                                anim.Play("CP12A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP12A"))
                            {
                                anim.Play("CP12R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "CorteP11":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("CP13A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP13R"))
                            {
                                anim.Play("CP13A");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CP13A"))
                            {
                                anim.Play("CP13R");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        default:

                            Nombre.text = "";
                            break;
                    }


                }
            }
        }


#endif
    }
}