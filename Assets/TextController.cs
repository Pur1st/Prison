﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		cell, sheets_0, grate, lock_0, sheets_1, cell_grate, lock_1,
		corridor_0, corridor_1, corridor_2, corridor_3, stairs_0, 
		stairs_1, stairs_2, floor, closet_door, in_closet   
		};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame 
	void Update () {
      	 updateRoomState ();
    }
		
	private void updateRoomState(){
		switch (myState) {
			case States.cell:
				cell();
				break;
			case States.sheets_0:
				sheets_0();
				break;
			case States.sheets_1:
				sheets_1();
				break;
			case States.lock_0:
				lock_0();
				break;
			case States.lock_1:
				lock_1();
				break;
			case States.grate:
				grate();
				break;
			case States.cell_grate:
				cell_grate();
				break;
			case States.corridor_0:
				corridor_0();
				break;
			case States.floor:
				floor();
				break;
			default:
				break;
			}
	}
	
	
	void cell () {
		text.text = "You wake up in a dimly lit cell." + 
					" A warm and fowl breeze blows from underneath the door. " +  
					" You have no memory of this place..." +
					" While struggling to get to your feet you notice" + 
					" there are some sheets on the floor" + 
					" covering a broken grate." +
					" You step over to check the door...\n\n" +
					" Press (S) to sniff the sheets, (G) to check the Grate and (L) to check the lock" ; 
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lock_0;}
	}
	
	void sheets_0 () {
		text.text = "They smell like they havent been washed in ages." + 
					" you lurch away when you see the blood stains. " +  
					" What the hell happened here!?\n\n" +
					" Press (R) to return to roaming your cell" ; 
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell;}
	}
	
	void sheets_1 () {
		text.text = "Using the sharp metal from the grate you tear a strip off the sheet" + 
					" to use as a bandana to soak up your sweat. Good thing red" +  
					" is your favorite color. This wont help much with that lock though...\n\n" +
					" Press (R) to return to roaming your cell" ; 
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell_grate;}
	}
	
	void lock_0 () {
		text.text = "This lock can't be opened without a key" + 
					" If only there was a way to get passed it without one...\n" +  
					" WWJD? \n\n" +
					" Press (R) to return to roaming your cell" ; 
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell;}
	}
	
	void lock_1 () {
		text.text = "Using the sharp metal from the grate you pick the lock" + 
					" Thanks for nothing Jesus...\n\n"  +  
					" Press (0) to open your cell" +
					" or press (R) and rot for eternity just because." ; 
		if (Input.GetKeyDown(KeyCode.O)) 			{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_grate;}
	}
	
	void grate () {
		text.text = "You notice a sharp piece of metal broken off the grate " + 
					" broken and laying on the floor" + 
					" I wonder if I could use that...\n\n"  +  
					" Press (T) to take the Sharp piece of grate" +
					" or press (R) and return to your cell." ; 
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.cell_grate;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell;}
	}
	
	void cell_grate () {
		text.text = "You contimplate stabbing your own throat when you decide " + 
					" there may be a better use for this sharp piece of grate." + 
					" \n\n"  +  
					" Press (S) to check the sheets" +
					" or press (L) and Look at the Lock." ; 
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lock_1;}
	}
	
	void corridor_0 () {
		text.text = "Sweet glory-hole, You are free..." + 
					" from that cell... not out of the fire yet." +
					" You see a set of stairs but hear strange groans coming from that direction"  +
					" Ahead you see a closet but can also spot and object laying on the floor" +
					" You take a moment to decide\n\n" +  
					" Press (S) to go upstairs, (C) to check the closet and (F) to check floor" ; 
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.cell;}
	}
	
	void floor () {
		text.text = "You find hair-pin that looks sharp enough to poke an eye out" + 
					" lets hope it doesnt come to that..." +
					" You see a set of stairs but hear strange groans coming from that direction"  +
					" Ahead you see a closet but can also spot and object laying on the floor" +
					" You take a moment to decide\n\n" +  
					" Press (S) to go upstairs, (C) to check the closet and (F) to check floor" ; 
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.cell;}
	}

}
