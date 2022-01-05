using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class FibonacciCanvas : MonoBehaviour
{
    public  long number1 = 0;
    public long number2 = 1;
    public  long next_number = 0;
    public Text display_value_textholder;

    //Next number in the Fibonacci sequence
    public void NextFibonacci()
    {
        Debug.Log("clicked the button");
        
        GetFibonacci(display_value_textholder);
    }

    //Display next Fibonacci number and sets the numbers ready for next display
    private void GetFibonacci(Text display_value)
    {
        display_value.text += next_number + ", ";

        number1 = number2;
        number2 = next_number;
        next_number = number1 + number2;

        // Debug.Log("test1 " + number1);
        // Debug.Log("test2 " + number2);
        // Debug.Log("testN " + next_number);
    }

    public void ResetFibonacci()
    {
        display_value_textholder.text = " ";
        number1 = 0;
        number2 = 1;
        next_number = number1 + number2;
    }
}
