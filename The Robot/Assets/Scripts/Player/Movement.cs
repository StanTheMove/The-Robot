using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float walkSpeed = 4;
    [SerializeField] float crouchSpeed = 2;
    
    private CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        
    }
}
