using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class GamePadRumble : MonoBehaviour, IPadRumble
{
    private Gamepad m_controller;
    void Update()
    {
        //------- NEEDS GAME MANAGER AND PAUSE SYSTEM FIRST -------
        //if (GameManager.s_instance.IsPaused() == true)
        //{
        //    InputSystem.PauseHaptics();
        //}
        //else
        //{
        //    InputSystem.ResumeHaptics();
        //}
    }

    public void PadRumble(float lowSpeed, float highSpeed, float duration)
    {
        m_controller = Gamepad.current;
        if (m_controller != null)
        {
            StartCoroutine(EPadVibrating(lowSpeed, highSpeed, duration));

        }

    }

    private IEnumerator EPadVibrating(float lowFreq, float highFreq, float duration)
    {
        float deltaT = 0.0f;
        while (deltaT < duration)
        {
            deltaT += Time.deltaTime;
            m_controller.SetMotorSpeeds(lowFreq, highFreq);
            yield return null;
        }
        m_controller.SetMotorSpeeds(0.0f, 0.0f);
    }
}
