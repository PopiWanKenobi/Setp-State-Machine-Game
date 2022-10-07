using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

    public InputActionProperty pointAnimationAction;
    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pointValue = pointAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", pointValue);
    }
}
