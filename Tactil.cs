using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Tactil : MonoBehaviour
{

    
    string ObjName;
    public Animator anim;
    private Text Nombre;
    private GameObject Eje;
    private bool avan;
    private bool primera;



    private void Start()
    {
        Nombre = GameObject.Find("Texto").GetComponent<Text>();
        Nombre.text = "";
        GameObject gameObject1 = GameObject.Find("Pieza1");
        Eje = gameObject1;
        avan = false;
        primera = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if(Physics.Raycast(ray , out hit))
            {
                if(hit.collider != null)
                {
                    ObjName = hit.transform.name;
                    
                    switch (ObjName)
                    {
                        case "Pieza12":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("del");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("atr"))
                            {
                                anim.Play("del");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("del"))
                            {
                                anim.Play("atr");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "Pieza11":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("2del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("2atr"))
                            {
                                anim.Play("2del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("2del"))
                            {
                                anim.Play("2atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza8-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("5del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("5atr"))
                            {
                                anim.Play("5del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("5del"))
                            {
                                anim.Play("5atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza8-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("6del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("6atr"))
                            {
                                anim.Play("6del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("6del"))
                            {
                                anim.Play("6atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("8del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("8atr"))
                            {
                                anim.Play("8del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("8del"))
                            {
                                anim.Play("8atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("14del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("14atr"))
                            {
                                anim.Play("14del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("14del"))
                            {
                                anim.Play("14atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("3del");
                                Nombre.text = ObjName.ToUpper();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("3atr"))
                            {
                                anim.Play("3del");
                                Nombre.text = ObjName.ToUpper();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("3del"))
                            {
                                anim.Play("3atr");
                                Nombre.text = ObjName.ToUpper();
                            }
                            break;
                        case "Pieza2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("4del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("4atr"))
                            {
                                anim.Play("4del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("4del"))
                            {
                                anim.Play("4atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("9del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("9atr"))
                            {
                                anim.Play("9del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("9del"))
                            {
                                anim.Play("9atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("15del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("15atr"))
                            {
                                anim.Play("15del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("15del"))
                            {
                                anim.Play("15atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza4-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("10del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("10atr"))
                            {
                                anim.Play("10del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("10del"))
                            {
                                anim.Play("10atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("7del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("7atr"))
                            {
                                anim.Play("7del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("7del"))
                            {
                                anim.Play("7atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-4":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("13del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("13atr"))
                            {
                                anim.Play("13del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("13del"))
                            {
                                anim.Play("13atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza4-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("11del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("11atr"))
                            {
                                anim.Play("11del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("11del"))
                            {
                                anim.Play("11atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza4-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("12del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("12atr"))
                            {
                                anim.Play("12del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("12del"))
                            {
                                anim.Play("12atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("17del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("17atr"))
                            {
                                anim.Play("17del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("17del"))
                            {
                                anim.Play("17atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("18del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("18atr"))
                            {
                                anim.Play("18del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("18del"))
                            {
                                anim.Play("18atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("19del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("19atr"))
                            {
                                anim.Play("19del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("19del"))
                            {
                                anim.Play("19atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("20del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("20atr"))
                            {
                                anim.Play("20del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("20del"))
                            {
                                anim.Play("20atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-4":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("21del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("21atr"))
                            {
                                anim.Play("21del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("21del"))
                            {
                                anim.Play("21atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("16del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("16atr"))
                            {
                                anim.Play("16del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("16del"))
                            {
                                anim.Play("16atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza9y10":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                if (primera)
                                {
                                    if (!avan)
                                    {
                                        Eje.GetComponent<Animator>().Play("3avan");
                                        avan = true;
                                    }
                                    if (avan)
                                    {
                                        anim.Play("22del");
                                        Eje.GetComponent<Animator>().Play("3ret");
                                        Nombre.text = ObjName.ToString();
                                        avan = false;
                                    }
                                    primera = false;
                                }
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("22atr"))
                            {
                                anim.Play("22del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("22del"))
                            {
                                anim.Play("22atr");
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
                        case "Pieza12":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("del");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("atr"))
                            {
                                anim.Play("del");
                                Nombre.text = ObjName.ToString();
                            }

                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("del"))
                            {
                                anim.Play("atr");
                                Nombre.text = ObjName.ToString();
                            }

                            break;
                        case "Pieza11":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("2del");
                                Nombre.text = ObjName.ToUpper();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("2atr"))
                            {
                                anim.Play("2del");
                                Nombre.text = ObjName.ToUpper();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("2del"))
                            {
                                anim.Play("2atr");
                                Nombre.text = ObjName.ToUpper();
                            }
                            break;
                        case "Pieza8-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("5del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("5atr"))
                            {
                                anim.Play("5del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("5del"))
                            {
                                anim.Play("5atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza8-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("6del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("6atr"))
                            {
                                anim.Play("6del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("6del"))
                            {
                                anim.Play("6atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("8del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("8atr"))
                            {
                                anim.Play("8del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("8del"))
                            {
                                anim.Play("8atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("14del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("14atr"))
                            {
                                anim.Play("14del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("14del"))
                            {
                                anim.Play("14atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("3del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("3atr"))
                            {
                                anim.Play("3del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("3del"))
                            {
                                anim.Play("3atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("4del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("4atr"))
                            {
                                anim.Play("4del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("4del"))
                            {
                                anim.Play("4atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("9del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("9atr"))
                            {
                                anim.Play("9del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("9del"))
                            {
                                anim.Play("9atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("15del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("15atr"))
                            {
                                anim.Play("15del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("15del"))
                            {
                                anim.Play("15atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza4-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("10del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("10atr"))
                            {
                                anim.Play("10del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("10del"))
                            {
                                anim.Play("10atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("7del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("7atr"))
                            {
                                anim.Play("7del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("7del"))
                            {
                                anim.Play("7atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza3-4":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("13del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("13atr"))
                            {
                                anim.Play("13del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("13del"))
                            {
                                anim.Play("13atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza4-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("11del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("11atr"))
                            {
                                anim.Play("11del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("11del"))
                            {
                                anim.Play("11atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza4-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("12del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("12atr"))
                            {
                                anim.Play("12del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("12del"))
                            {
                                anim.Play("12atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza6":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("17del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("17atr"))
                            {
                                anim.Play("17del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("17del"))
                            {
                                anim.Play("17atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-1":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("18del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("18atr"))
                            {
                                anim.Play("18del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("18del"))
                            {
                                anim.Play("18atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-2":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("19del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("19atr"))
                            {
                                anim.Play("19del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("19del"))
                            {
                                anim.Play("19atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-3":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("20del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("20atr"))
                            {
                                anim.Play("20del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("20del"))
                            {
                                anim.Play("20atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza7-4":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("21del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("21atr"))
                            {
                                anim.Play("21del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("21del"))
                            {
                                anim.Play("21atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza5":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                anim.Play("16del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("16atr"))
                            {
                                anim.Play("16del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("16del"))
                            {
                                anim.Play("16atr");
                                Nombre.text = ObjName.ToString();
                            }
                            break;
                        case "Pieza9y10":
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("nada"))
                            {
                                if (primera)
                                {
                                    if (!avan)
                                    {
                                        Eje.GetComponent<Animator>().Play("3avan");
                                        avan = true;
                                    }
                                    if (avan)
                                    {
                                        anim.Play("22del");
                                        Eje.GetComponent<Animator>().Play("3ret");
                                        Nombre.text = ObjName.ToString();
                                        avan = false;
                                    }
                                    primera = false;
                                }
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("22atr"))
                            {
                                anim.Play("22del");
                                Nombre.text = ObjName.ToString();
                            }
                            if (anim.GetCurrentAnimatorStateInfo(0).IsName("22del"))
                            {
                                anim.Play("22atr");
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
