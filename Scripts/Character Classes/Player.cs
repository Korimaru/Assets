using System;
using UnityEngine;

[RequireComponent(typeof(GroundedMovement))]
public class Player : Character
{
    private GroundedMovement m_Character;
    private bool m_Jump;


    private void Awake()
    {
        m_Character = GetComponent<GroundedMovement>();
    }


    private void Update()
    {
        if (!m_Jump)
        {
            // Read the jump input in Update so button presses aren't missed.
            m_Jump = Input.GetKeyDown(KeyCode.W);
        }
    }


    private void FixedUpdate()
    {
        // Read the inputs.
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        float h = Input.GetAxis("Horizontal");
        // Pass all parameters to the character control script.
        m_Character.Move(h, crouch, m_Jump);
        m_Jump = false;
    }
}