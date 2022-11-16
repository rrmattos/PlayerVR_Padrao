using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class VRTalk : MonoBehaviour
{
    public string NomeCenaSalaReunioes;
    public GameObject CanvasVoice;
    public InputActionProperty TalkAction;
    //public Menu menuManager;

    private bool esperar;
    
    void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals(NomeCenaSalaReunioes))
        {
            if (!esperar)
            {
                /*if (ReferenceEquals(menuManager, null))
                {

                    menuManager = GameObject.Find("ManagerMapCanvas").GetComponent<Menu>();
                    StartCoroutine(Timer(1.5f));
                    esperar = true;
                }      
                else*/
                {
                    if (TalkAction.action.IsPressed())
                    {
                        CanvasVoice.SetActive(true);
                        //menuManager.UnMute();
                    }

                    if (TalkAction.action.WasReleasedThisFrame())
                    {
                        CanvasVoice.SetActive(false);
                        //menuManager.Mute();
                    }
                }
            }
        }
    }

    private IEnumerator Timer(float _time)
    {
        yield return new WaitForSeconds(_time);
        esperar = false;
    }
}
