using UnityEngine;

public class PlayerAnimatorScript : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private PlayerScript player; 

    private const string IS_WALKING = "IsWalking";

    private void Awake()
    {
        playerAnimator.SetBool(IS_WALKING, player.IsWalking());
    }

    private void Update()
    {
        playerAnimator.SetBool(IS_WALKING, player.IsWalking());
    }
}