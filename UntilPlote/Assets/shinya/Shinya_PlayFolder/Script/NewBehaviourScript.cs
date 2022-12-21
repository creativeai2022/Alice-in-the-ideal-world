using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float speed = 0.05f;
    [SerializeField] float smooth = 10f;

        public enum Status
    {   
        Stop,
        Move,
        Dash,
        Event,
        Battle,
        Pause,
    }
    public Status status;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        status = Status.Stop;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (status == Status.Stop || status == Status.Move)
        {

            var horizontalRotation = Quaternion.AngleAxis(Camera.main.transform.eulerAngles.y, Vector3.up);
            Vector3 target = horizontalRotation *  new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
            if (target.magnitude > 0.1)
            {
                //�̂̌��������炩�ɕύX����
                Quaternion rotation = Quaternion.LookRotation(target);
                transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);
                //�O���ֈړ�
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
        
            gameObject.transform.position += target * Time.deltaTime;

        
            if (target.x != 0 || target.z != 0)
            {
                status = Status.Move;
                anim.SetBool("is_walking", true);
            }
            else
            {
                status = Status.Stop;
                anim.SetBool("is_walking", false);
            }

        }
    }
}
