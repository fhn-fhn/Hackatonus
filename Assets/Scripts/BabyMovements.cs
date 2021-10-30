using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.UI;

// Use action set asset instead of lose InputActions directly on component.
public class BabyMovements : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    public float burstSpeed;
    private Animator _anim;

   // private SimpleControls m_Controls;
    private BabyInput m_Controls;
    private bool m_Charging;
    private Vector2 m_Rotation;

    private float _burstPoints, _burstTotalNeed;
    [SerializeField] Slider _slider;
    public void Awake()
    {
        m_Controls = new BabyInput();
        _anim = GetComponent<Animator>();
        m_Controls.BabyMovement.Force.performed += ctx => SetBool();
        _burstTotalNeed = 30;
        _slider.maxValue = _burstTotalNeed;
    }
    void SetBool()
    {
        if (!m_Charging && _burstPoints > 1) 
        {
            m_Charging = true;
            burstSpeed = 3;
        }
        else
        {
            m_Charging = false;
            burstSpeed = 1;
        }

        _anim.SetBool("Run", m_Charging);
    }
    public void OnEnable()
    {
        m_Controls.Enable();
    }

    public void OnDisable()
    {
        m_Controls.Disable();
    }


    public void Update()
    {
        var look = m_Controls.BabyMovement.Rotate.ReadValue<Vector2>();
        var move = m_Controls.BabyMovement.Move.ReadValue<Vector2>();
        _anim.SetFloat("MoveForward", move.y);
        _anim.SetFloat("MoveRight", move.x);
        Look(look);
        Move(move);

        if(_burstPoints < _burstTotalNeed && !m_Charging)
        {
            _burstPoints += Time.deltaTime;
        }else if(!m_Charging)
        {
            _burstPoints = _burstTotalNeed;
        }
        else if (m_Charging && _burstPoints < 0)
        {
            _burstPoints = 0;
            SetBool();
        }
        else if(m_Charging)
        {
            _burstPoints -= Time.deltaTime * 3;
        }
        _slider.value = _burstPoints;

    }

    private void Move(Vector2 direction)
    {
        if (direction.sqrMagnitude < 0.01)
            return;
        var scaledMoveSpeed = moveSpeed * Time.deltaTime * burstSpeed;

        var move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
        transform.position += move * scaledMoveSpeed;
    }

    private void Look(Vector2 rotate)
    {
        if (rotate.sqrMagnitude < 0.01)
            return;
        var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
        m_Rotation.y += rotate.x * scaledRotateSpeed;
        //  m_Rotation.x = Mathf.Clamp(m_Rotation.x - rotate.y * scaledRotateSpeed, -89, 89);
        m_Rotation.x = 0;
        transform.localEulerAngles = m_Rotation;
    }

  

   
}
