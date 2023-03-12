using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 7f;
    [SerializeField] private PlayerInputScript input; 
    private bool isWalking = false;

    private void Update()
    {
        Vector2 inputVector = input.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        transform.position += moveDir * Time.deltaTime * playerSpeed;

        isWalking = moveDir != Vector3.zero;    

        float rotateSpeed = 10f; 
        transform.forward = Vector3.Slerp(transform.forward, moveDir, rotateSpeed * Time.deltaTime);
    }

    public bool IsWalking()
    {
        return isWalking;
    }

}