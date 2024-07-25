using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogOption : MonoBehaviour

{
    public string Text;

    public DialogItem NextDialog;

    public UnityEvent onDialogSelected;

    public GameObject ObjectDeactivate;
    public GameObject ObjectActivate;

    public GameObject ObjectDeactivate2;
    public GameObject ObjectActivate2;

    public Animator AnimatorDeactivate;


    public void OnDisable()
    {
        if (ObjectDeactivate != null)
        {
            ObjectDeactivate.SetActive(false);
            ObjectActivate.SetActive(true);

        }

        if (ObjectDeactivate != null)
        {
            ObjectDeactivate2.SetActive(false);
            ObjectActivate2.SetActive(true);

        }




    }
}








