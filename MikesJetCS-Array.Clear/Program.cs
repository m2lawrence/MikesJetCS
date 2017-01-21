//Michael Lawrence BSc (HONS) 
using System;
namespace MikesJetCS
{
	class Program
	{
	public static void mainMenu() //Main Menu code
	{
	Console.WriteLine("   ****Welcome to the MikesJet automated seat reservation system.**** "+ DateTime.Now);
	Console.WriteLine();
	Console.WriteLine("       MAIN MENU");
	Console.WriteLine();
	Console.WriteLine("Please choose from the following options.... ");
	Console.WriteLine();
	Console.WriteLine("   1.  Reservations");
	Console.WriteLine();
	Console.WriteLine("   2.  Availability");
	Console.WriteLine();
	Console.WriteLine("   3.  Array.Clear");
	Console.WriteLine();
	Console.WriteLine("   4.  Exit");
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine("   Please enter your choice: ");
	}
		
	public static void reservMenu() //Reservations Menu code
	{
        Console.WriteLine();
        Console.WriteLine("       RESERVATIONS          "+ DateTime.Now);
        Console.WriteLine();
        Console.WriteLine(" Please choose from the following options.... ");
        Console.WriteLine();
        Console.WriteLine("   1.  Executive ");
        Console.WriteLine();
        Console.WriteLine("   2.  Luxury ");
        Console.WriteLine();
        Console.WriteLine("   3.  Return to Main Menu ");
        Console.WriteLine();
        Console.WriteLine("   Please enter your choice: ");
 	}
	
	public static void Main(string []args)
	{
	String[] luxSeat = new String [4];
        String[] execSeat = new String [6];
        String menuChoice;
        String submenuChoice;
        String menuChoose;
        int execNo = 0;
        int luxNo = 0;
        int tempLux = 0;
        int tempExec = 0;
        int n = 99999999;
        int clear;
        Random r = new Random();
		
     	do //looping upto 3.
     	{
     	//-------------------------------------------
	for (clear = 0; clear <=50; clear++) {Console.WriteLine();} //clear the screen.                
	mainMenu();//bring up Main Menu
	menuChoice = Console.ReadLine(); //enter data.		
	if (menuChoice.Equals("1")) //Reservations
	{
	luxNo = tempLux;
        execNo = tempExec;
        for(clear=0; clear<=50; clear++) {Console.WriteLine();}  //50 blank lines.
        reservMenu();//bring up Reservations Menu
        submenuChoice = Console.ReadLine(); //enter data.
        //--------------------------------------------------
		    	
            	if (submenuChoice.Equals ("1"))// Executive
            	{
                for(clear=0; clear<=50; clear++) {Console.WriteLine();}  //50 blank lines.
                Console.WriteLine("Would you like to book a seat?   y? or n?");
                menuChoose = Console.ReadLine(); //enter data.
            
               	    //-------------------------------------------------------------------------------------------------------------------
               	    while (menuChoose.Equals("y") && execNo < 6)
               	    {  
                    Console.Write("Please enter your name: ");
                    execSeat[execNo] = Console.ReadLine(); //enter data.
                    
                    // Print ticket...
                    Console.WriteLine();
                    Console.WriteLine("|-----MikesJet TICKET----------------------------------"+ DateTime.Now +"|");
                    Console.WriteLine("|                                                                         |");                                                          
                    Console.WriteLine("|     Executive seat number " + "E" + (execNo)  + " is booked by " + execSeat[execNo]);
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|Booking No: " + r.Next(n) + "-----------------------------------Enjoy your flight!|");
                    Console.WriteLine();    
                    execSeat[execNo] = execSeat[execNo++];
                    Console.WriteLine("Would you like to book another executive seat?   y? or n?");
                    menuChoose = Console.ReadLine();  
                
                    if (menuChoose.Equals("n"))
                    {
                        Console.WriteLine("Thankyou for your booking");
                        Console.ReadKey(true);
                        mainMenu(); //Main Menu code ----------------------------------------------------------------
                    }
                    
                    if (execNo >=6)
                    {
                        Console.WriteLine(" All seats are booked, thankyou.");
                        Console.ReadKey(true);
                    }
                }
            }
            //---------------------------------------
       	    if (submenuChoice.Equals("2")) //Luxury
       	    {
            for(clear=0; clear<=50; clear++) {Console.WriteLine();}  //50 blank lines.
            Console.WriteLine("Would you like to book a seat?   y? or n?");
            menuChoose = Console.ReadLine();
            
            	while (menuChoose.Equals("y") && luxNo < 4)
            	{  
                Console.WriteLine("Please enter your name: ");
                luxSeat[luxNo] = Console.ReadLine();
                                  
                // Print ticket...
                Console.WriteLine();
                Console.WriteLine("|-----MikesJet TICKET----------------------------------"+ DateTime.Now +"|");
                Console.WriteLine("|                                                                         |");                                                          
                Console.WriteLine("|     Luxury seat number " + "L" + (luxNo)  + " is booked by " + luxSeat[luxNo]);
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|Booking No: " + r.Next(n) + "-----------------------------------Enjoy your flight!|");
                Console.WriteLine();         
                luxSeat[luxNo] = luxSeat[luxNo++];
                Console.WriteLine("Would you like to book another luxury seat?   y? or n?");
                menuChoose = Console.ReadLine();
            
                if (menuChoose.Equals("n"))
                {
                    Console.WriteLine("Thankyou for your booking");
                    Console.ReadKey(true);
                    
                     mainMenu();//bring up Main Menu
					 menuChoice = Console.ReadLine(); //enter data.	
                }
                
                if (luxNo >=4)
                {
                    Console.WriteLine(" All seats are booked, thankyou.");
                    Console.ReadKey(true);
                }
            	
               } //close while loop. 
            } // close if =2 loop.
		    
        	tempLux = luxNo;
        	tempExec = execNo;
		//-----------------------------------------------
		}
		
		
	if(menuChoice.Equals("2")) //Availability                    
    	{
        for(clear=0; clear<=50; clear++) {Console.WriteLine();}  //50 blank lines.
        Console.WriteLine("         PASSENGER MANIFEST          ");
        Console.WriteLine("");                     
        Console.WriteLine("            **Executive**");
        
        for (execNo = 0; execNo <=5; execNo++)
        {
        Console.WriteLine("Seat number " + "E" + (execNo)  + " is booked by " + execSeat[execNo]);
        }
        
        Console.WriteLine("");                     
        Console.WriteLine("            **Luxury**");        
        for (luxNo =0; luxNo <=3; luxNo++)
        {
            Console.WriteLine("Seat number " + "L" + (luxNo)  + " is booked by " + luxSeat[luxNo]);
        }                  
        Console.WriteLine("");
        Console.WriteLine("Press any key to return to Main Menu.");
        Console.ReadKey(true);
        for (clear = 0; clear <=50; clear++) {Console.WriteLine();} //50 blank lines.               
        mainMenu(); //Main Menu
        Console.ReadKey(true);
	}
	
	if(menuChoice.Equals("3")) //Clear Array.                    
    	{
	// Clear all elements in the array.
	Array.Clear(luxSeat, 0, luxSeat.Length);
	Array.Clear(execSeat, 0, execSeat.Length);
	
	Console.WriteLine("Done Mike.");
	Console.WriteLine("Array.Clear... have a nice day!");
	Console.ReadKey(true);
	}
	
        }while(menuChoice != "4"); //4 is to Exit. 
	for (clear = 0; clear <=50; clear++) {Console.WriteLine();} //clear the screen.                    
	Console.WriteLine();
	Console.WriteLine("\n\nThankyou for booking with MikesJet, and have a nice day!");
	Console.ReadKey(true); //pause.
     		
     		} //close main(String[]args).
         } //close Class.		
     } //close Package.