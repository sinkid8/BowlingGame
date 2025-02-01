using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager; // Assign in the Inspector

    private bool isBallLaunched;
    private Rigidbody ballRB;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>(); 
        inputManager?.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        // "If ball is launched, then simply return and do nothing"
        if (isBallLaunched) return;

        // "Now that the ball is not launched, set it to true and launch the ball"
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
