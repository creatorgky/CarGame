using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public string targetObjectName;
    public string sceneNameToLoad;

    // Trigger tetiklendiğinde bu fonksiyon çalışır
    private void OnTriggerEnter(Collider other)
    {
        // Eğer belirli bir hedef obje ismi kontrolü gerekiyorsa:
        if (other.gameObject.name == targetObjectName)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

    // Eğer Trigger yerine normal bir çarpışma kullanıyorsanız
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
