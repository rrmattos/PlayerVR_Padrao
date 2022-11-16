using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TecladoManager : MonoBehaviour
{ 
    /// Text object that the script will modify
    public InputField InputFieldNameVR;
    public InputField InputFieldPassVR;
    public InputField InputFieldChatVR;

    /// User specifies character that the key will input
    public char key;

    /// Timer for input delay
    private float timer = 0;

    /// User specified float for seconds to delay before accepting more input
    public float timeDelay = 0;

    private bool isCapsAtivo = false;
    private InputFieldManager.Inputs inputFields = InputFieldManager.Inputs.name;

    public void AddText(string _text)
    {
        //if (Time.time - timer > timeDelay)
        //{
        if (isCapsAtivo)
        {
            _text = _text.ToUpper();
        }

        if (inputFields.Equals(InputFieldManager.Inputs.name))
        {
            InputFieldNameVR.text += _text;
        }
        else if (inputFields.Equals(InputFieldManager.Inputs.pass))
        {
            InputFieldPassVR.text += _text;
        }
        else if (inputFields.Equals(InputFieldManager.Inputs.chat))
        {
            InputFieldChatVR.text += _text;
        }
        
        //timer = Time.time;
        //}
    }

    public void Apagar()
    {
        if (inputFields.Equals(InputFieldManager.Inputs.name))
        {
            InputFieldNameVR.text = InputFieldNameVR.text.Substring(0, InputFieldNameVR.text.Length - 1);
        }
        else if (inputFields.Equals(InputFieldManager.Inputs.pass))
        {
            InputFieldPassVR.text = InputFieldPassVR.text.Substring(0, InputFieldPassVR.text.Length - 1);
        }
        else if (inputFields.Equals(InputFieldManager.Inputs.chat))
        {
            InputFieldChatVR.text = InputFieldChatVR.text.Substring(0, InputFieldChatVR.text.Length - 1);
        }
    }

    public void Enter()
    {
        if (inputFields.Equals(InputFieldManager.Inputs.name))
        {
            EventSystem.current.SetSelectedGameObject(InputFieldPassVR.gameObject);
        }
        else if (inputFields.Equals(InputFieldManager.Inputs.pass))
        {
            GameObject.Find("ConfirmButton").GetComponent<Button>().Select();
        }
        /*else if (inputFields.Equals(InputFieldManager.Inputs.chat))
        {
            GameObject.Find("SendButton").GetComponent<Button>().Select();
        }*/
    }

    public void Capslock()
    {
        isCapsAtivo = !isCapsAtivo;
    }

    public void AlterarInputField(InputFieldManager.Inputs _inputs)
    {
        inputFields = _inputs;
    }
}

