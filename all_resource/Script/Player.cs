using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]  private float _speed = 5f;
    [SerializeField] private float _force = 40f;
    //[SerializeField] private float _jumpForce = 5f;
    [SerializeField] private float _forward = 300f;
    private bool _active = true;


    private float Xinput;
    private float Yinput;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
       // Movement(_active);
        PlayerMove(_active);

        if (_rb.position.y < -2f)
        {
            FindFirstObjectByType<GameManagerscript>().EndGame();
        }
    }

    private void Movement(bool action)
    {
        if (action)
        {
            _rb.AddForce(0f, 0f, _forward * _speed * Time.deltaTime);
            Xinput = Input.GetAxisRaw("Horizontal");
            Yinput = Input.GetAxisRaw("Vertical");
            //if (Input.GetButtonDown("Jump"))
            //{
            //    _rb.AddForce(0, 40*_jumpForce, 0);
            //}

            transform.position += new Vector3(Xinput, 0f, 0f) * _speed * Time.deltaTime;
            //_rb.AddForce(Xinput*_speed, 0f, Yinput*_speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstical")
        {
            _active = false;
            FindFirstObjectByType<GameManagerscript>().EndGame();
        }
    }
    private void PlayerMove(bool action)
    {
        if (action)
        {
            _rb.AddForce(0f, 0f, _forward * _speed * Time.deltaTime);
            if (Input.GetKey("d"))
            {
                _rb.AddForce(_force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                _rb.AddForce(-_force * Time.deltaTime, 0f, 0f, ForceMode.VelocityChange);
            }
        }
    }
}
