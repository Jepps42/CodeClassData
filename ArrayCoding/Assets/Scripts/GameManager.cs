using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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

    private GameObject[] floors;

    //Make alist for floors
    public List<GameObject> flList;

    //Make a stack for students
    //Stack in LIFO (Last in First Out)
    public Stack<string> stuStack = new Stack<string>();

    //Make a queue for students
    //Queue is FIFO (First in First Out)
    public Queue<string> stuQueue = new Queue<string>();


    //Make an ArrayList
     public ArrayList stuff = new ArrayList(); 

    // Start is called before the first frame update
    void Start()
    {
        stuList.AddRange(students);
        students[6] = stu1;
        //floors = GameObject.FindGameObjectsWithTag("Floors");
        //Remove absent students from the list
        stuList.Remove("Evri");

        stuff.Add(stu1);
        stuff.Add(15);
        stuff.Add(this.gameObject);
        //flList.AddRange(floors);

        //Add every student inside the list stuList to my stack
        foreach (string s in stuList)
        {
            stuStack.Push(s);
        }

        Debug.Log(stuStack.Pop());

        Debug.Log(stuff[1].GetType().Name);
    }

    // Update is called once per frame
    void Update()
    {
        //Print the number of items in the list and array
        //LIST COUNT
        //Debug.Log(stuList.Count);
        //ARRAY LENGTH
        //Debug.Log(students.Length);
        //-1 for <= no -1 for <
        /*for (int i = 0; i < students.Length ; i++)
        {
            Debug.Log(students[i]);
        }*/
    }
}
