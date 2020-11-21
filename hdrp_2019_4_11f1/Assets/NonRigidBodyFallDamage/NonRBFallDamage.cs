using UnityEngine;

public class NonRBFallDamage : MonoBehaviour {
    [SerializeField, Range(0f, 1f)] private float _fallDamageThreshold = 0.3f;
    
    private Vector3 _lastPosition;
    private float _lastYDelta;

    private void Update(){
        // The difference in position from this frame and the last frame, this is our acceleration
        var curPosDelta = _lastPosition - transform.position;
        
        // We only care about our acceleration due to gravity, so just taking the y axis.
        var yChange = _lastYDelta - curPosDelta.y;
        // Now we're checkinf if the yChange is greater then our fall damage threshold, and if our y delta was in the right direction
        if (yChange > _fallDamageThreshold){
            Debug.Log(yChange);
            // Debug.Log($"Take Fall Damage!");
        }

        // Store our last position for next Update
        _lastYDelta = curPosDelta.y;
        _lastPosition = transform.position;
    }

}
