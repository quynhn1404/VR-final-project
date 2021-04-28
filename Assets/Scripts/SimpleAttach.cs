using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class SimpleAttach : MonoBehaviour
{
    private Interactable interactable;
    public Collider collider;
    public bool needCollider;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    private void OnHandHoverBegin(Hand hand)
    {
        hand.ShowGrabHint();
    }
    private void OnHandHoverEnd(Hand hand)
    {
        hand.HideGrabHint();
    }
    private void HandHoverUpdate(Hand hand)
    {
        GrabTypes grab = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(gameObject);
        // grabbing object
        if(interactable.attachedToHand == null && grab != GrabTypes.None)
        {
            hand.AttachObject(gameObject, grab);
            hand.HoverLock(interactable);
            hand.HideGrabHint();
            if(needCollider)
                collider.enabled = true;
        }
        // release
        else if(isGrabEnding)
        {
            hand.DetachObject(gameObject);
            hand.HoverUnlock(interactable);
        }
    }
}
