using UnityEngine;
using UnityEngine.Events;

public class AnimationRelay : MonoBehaviour
{
    public UnityEvent OnTrigger;

    public void TriggerEvent()
    {
        OnTrigger.Invoke();
    }
}
