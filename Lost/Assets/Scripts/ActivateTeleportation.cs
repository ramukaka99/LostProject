using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportation : MonoBehaviour
{
    public GameObject RightTeleportation;

    public InputActionProperty RightActivate;


    // Update is called once per frame
    void Update()
    {
        RightTeleportation.SetActive(RightActivate.action.ReadValue<float>() > 0.1f);
    }
}
