using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SetTurnType : MonoBehaviour
{
    public ActionBasedContinuousTurnProvider continuousProvider;
    public ActionBasedSnapTurnProvider snapProvider;

    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            continuousProvider.enabled = true;
            snapProvider.enabled = false;
        }else if (index == 1)
        {
            continuousProvider.enabled = false;
            snapProvider.enabled = true;
        }
    }
}
