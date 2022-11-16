using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    public enum Inputs { name, pass, chat }
    public Inputs InputType;

    public TecladoManager TecladoManager;

    private InputField thisInputField;

    private void Start()
    {
        thisInputField = (InputField)GetComponent("InputField");
    }

    private void Update()
    {
        if (thisInputField.isFocused)
        {
            TecladoManager.AlterarInputField(InputType);
        }
    }
}
