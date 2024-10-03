using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables 

    //Create a empty array of strings
    //1 Option to write array
    public string [] students = new string[7] {"Colin", "Emmanuel", "Bella", "Justin", "Evri", "LeBron", "Joseph"};
    
    //2nd option to write array
    private string stu1 = "Manu";

    //Make a list of strings
    public List<string> stuList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        stuList.AddRange(students);
        students[6] = stu1;
        //Remove absent students from the list
        stuList.Remove("Evri");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
