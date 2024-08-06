
using UnityEngine;
using UnityEngine.UIElements;

public class MoveCarBetter : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float limitValue;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            {
                MovePlayer();
            }

        }
    }
        private void MovePlayer()
        {
            float halfScreen = Screen.width / 2;
            float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;
            float finalXpos = Mathf.Clamp(xPos * limitValue, -limitValue, limitValue);

            playerTransform.localPosition = new Vector3(finalXpos, 1, 24);    
        }
}   
