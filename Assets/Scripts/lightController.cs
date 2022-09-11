using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;



public class lightController : XRGrabInteractable
{
    bool active;
    public bool beingHeld;
    public InputActionReference lightActionReference1;
    public InputActionReference lightActionReference2;


    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        beingHeld = true;
        base.OnSelectEntered(args);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        beingHeld = false;
        base.OnSelectExited(args);
    }

    // Update is called once per frame
    private void Update()
    {
        lightActionReference1.action.performed += LightSwitcher;
        lightActionReference2.action.performed += LightSwitcher;
        if (active == true)
        {
            Debug.Log("Position to be sent to enemy:" + transform.position);
        }
    }

    void LightSwitcher(InputAction.CallbackContext obj)
    {
        if (beingHeld == true)
        {
            active = !active;
            GetComponent<Light>().enabled = active;
        }

        
    }
}
