using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		cell, cell_again, sheets_0, grate, lock_0, sheets_1, cell_grate, lock_1,
		corridor_0, corridor_1, corridor_2, corridor_3, stairs_0, 
		stairs_1, stairs_2, floor, closet_door, in_closet, courtyard   
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
			case States.cell_again:
				cell_again();
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
			case States.corridor_1:
				corridor_1();
				break;
			case States.corridor_2:
				corridor_2();
				break;
			case States.corridor_3:
				corridor_3();
				break;
			case States.floor:
				floor();
				break;
			case States.stairs_0:
				stairs_0();
				break;
			case States.stairs_1:
				stairs_1();
				break;
			case States.stairs_2:
				stairs_2();
				break;
			case States.closet_door:
				closet_door();
				break;
			case States.in_closet:
				in_closet();
				break;
			case States.courtyard:
				courtyard();
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
					" Some sheets crumpled up on the floor." + 
					" Covering a broken grate." +
					" You step over to check the door...\n\n" +
					" Press (S) to examine the sheets, (G) to check the grate and (L) to check the lock" ; 
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lock_0;}
	}
	
	void cell_grate () {
		text.text = "You contimplate stabbing your own throat when you decide " + 
					" there may be a better use for this sharp piece of grate.\n\n" + 
					" Press (S) to check the sheets" +
					" or press (L) and Look at the Lock." ; 
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.L)) 		{myState = States.lock_1;}
	}
	
	void cell_again () {
		text.text = "You are still in the cell." + 
					" You can see a faint light underneath the door. " +  
					" You imagine what horrors are in this place..." +
					" There has to be a way out..." + 
					" What's the deal with those sheets." + 
					" This is just grate..." +
					" \n\n" +
					" Press (S) to examine the sheets, (G) to check the grate" ; 
		if (Input.GetKeyDown(KeyCode.S)) 			{myState = States.sheets_0;}
		else if (Input.GetKeyDown(KeyCode.G)) 		{myState = States.grate;}
	}
	void sheets_0 () {
		text.text = "They smell like they havent been washed in ages." + 
					" Why would you smell them? " +
					" You lurch away when you see blood stains. " +  
					" What the hell happened here? " +
					" \n\n " +
					" Press (R) to return to your cell" ; 
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell_again;}
	}
	
	void sheets_1 () {
		text.text = "Why bother with the sheets?" + 
					"You can smell them just fine from where you are." +
					"\n\n" +
					" Press (R) to return to roaming your cell" ; 
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell_grate;}
	}
	
	void lock_0 () {
		text.text = "This lock can't be opened without a key" + 
					" If only there was a way to get passed it without one..." +  
					" \n\n" +
					" Press (R) to return to roaming your cell" ; 
		if (Input.GetKeyDown(KeyCode.R)) 			{myState = States.cell_again;}
	}
	
	void lock_1 () {
		text.text = "Perhaps you could use the sharp piece of grate" + 
					" to pick the lock and quietly sneak through?" +
					" Or maybe sit here stay awhile and listen? "  + 
					" \n\n" + 
					" Press (0) to open your cell" +
					" or press (R) and rot for eternity just because." ; 
		if (Input.GetKeyDown(KeyCode.O)) 			{myState = States.corridor_0;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_grate;}
	}
	
	void grate () {
		text.text = "You notice a sharp piece of metal broken off the grate " + 
					" broken and laying on the floor." + 
					" I wonder if I could use that? \n\n"  +  
					" Press (T) to take the Sharp piece of grate" +
					" or press (R) and return to your cell." ; 
		if (Input.GetKeyDown(KeyCode.T)) 			{myState = States.cell_grate;}
		else if (Input.GetKeyDown(KeyCode.R)) 		{myState = States.cell_again;}
	}
	
	
	void corridor_0 () {
		text.text = "Out of the frying pan " + 
					" ... not out of the fire yet." +
					" You see a set of stairs but hear strange sounds coming from that direction"  +
					" Ahead you see a closet but can also spot and object laying on the floor" +
					" You take a moment to decide...\n\n" +  
					" Press (S) to go upstairs, (C) to check the closet and (F) to check floor" ; 
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.stairs_0;}
		else if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.in_closet;}
	}
	
	void corridor_1 () {
		text.text = "You spot the same object on the floor..." + 
					" Now that you think about it the closet door is." +
					" still there too.."  +
					" You take a moment to decide\n\n" +  
					" Press (S) to go upstairs, (C) to check the closet and (F) to check floor" ; 
		if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.stairs_2;}
		else if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.closet_door;}
		else if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.in_closet;}	
	}
		
	void corridor_2 () {
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
	
	void corridor_3 () {
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
	
	void stairs_0 () {
		text.text = "You start to climb the stairs and hear" + 
					" footsteps just ahead of the staircase." +
					" Not the best choice of the three...\n\n"  +   
					" Press (R) to return to the corridor" ; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.corridor_1;}
	}
	
	void stairs_1 () {
		text.text = "Why am I back here..." + 
				    " It is waaaay to scary...\n\n" +
					" Press (R) return to the corridor";
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.corridor_1;}
	}
	
	void stairs_2 () {
		text.text = "For Christ sake I am not going up there." + 
					" I'm not wearing my shitting pants!" +
					" \n\n" +  
					" Press (R) to go back to the corridor" ; 
		if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.corridor_1;}
		
	}
	
	void floor () {
		text.text = "You find hair-pin that looks sharp enough to poke an eye out" + 
					" lets hope it doesnt come to that..." +
					" You see a set of stairs but STILL hear strange sounds coming from that direction"  +
					" Ahead you see a closet" +
					" You take a moment to decide\n\n" +  
					" Press (S) to go upstairs, (C) to check the closet and" ; 
		if (Input.GetKeyDown(KeyCode.C)) 				{myState = States.in_closet;}
		else if (Input.GetKeyDown(KeyCode.C)) 			{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.F)) 			{myState = States.cell;}
	}
	
	void closet_door () {
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
	
	void in_closet () {
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
	
	void courtyard () {
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
	
}