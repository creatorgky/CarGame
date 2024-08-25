
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCarBetter : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue;
    Animator anim;
    

    private void Start()
    {
        anim = GetComponent<Animator>();    
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            {
                MovePlayer();
                anim.SetBool("IsCarGoesRight", true);

            }
        }
      
    }
        private void MovePlayer()
        {
            float halfScreen = Screen.width / 2;
            float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
            float finalXpos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);

            playerTransform.localPosition = new Vector3(finalXpos, 0, 0);

        }
}   
