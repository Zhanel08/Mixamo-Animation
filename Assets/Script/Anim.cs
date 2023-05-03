using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private string _animName;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Run();
        Walk();
        Jump();
        BackWalk();
    }
    private void Walk()
    {
        _animName = "isWalking";
        if (Input.GetKey(KeyCode.W))
            SetBoolTrue();
        else
            SetBoolFalse();
    }
    private void Run()
    {
        _animName = "isRunning";
        if (Input.GetKey(KeyCode.LeftShift))
            SetBoolTrue();
        else
            SetBoolFalse();
    }
    private void Jump()
    {
        _animName = "isJumping";
        if (Input.GetKey(KeyCode.Space))
            SetBoolTrue();
        else
            SetBoolFalse();

    }
    private void BackWalk()
    {
        _animName = "isBackWalking";
        if (Input.GetKey(KeyCode.S))
            SetBoolTrue();
        else
            SetBoolFalse();

    }
    private void SetBoolFalse()
    {
        animator.SetBool(_animName, false);
    }
    private void SetBoolTrue()
    {
        animator.SetBool(_animName, true);
    }
}
