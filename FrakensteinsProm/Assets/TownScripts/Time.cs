using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{

    //member variables
    int currentTime;  //0 school time, 1 after school, 2 night

    public enum TimeOfDay {

        SchoolTime = 0,
        AfterSchool = 1,
        Evening = 2

    }
  
    int currentDay; //the current day.  should be < daysToProm. 
    public int daysToProm; //if currentDay = daysToProm, the game is over.  


   //time and day methods
    //increase the time of day.  
    public void addTime()
    {

        currentTime++;

        if (currentTime > 2)
        {

            currentTime = 0;
            addDay();

        }

        else {

        }

        Debug.Log("Time is " + currentTime);
        Debug.Log("Day #" + currentDay);
    }


    //increase the time of day.  
    void addDay()
    {

        currentDay++;

    }

    // returns current Day
    public int getCurrentDay()
    {

        return currentDay;

    }

    public bool isItPromDay() {

        if (currentDay == daysToProm){

            // game ends! or something
            return true;

        }

        else{

            return false;

        }

    }


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        currentDay = 1;
        
    }

    
    
}
