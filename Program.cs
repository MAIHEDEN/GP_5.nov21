/////     
/////  Kommentar, som bliver et summary, som knytter sig til matoden i kommentaren
/////
////TODO: Lave logik. Denne kan findes

/////     
/////     Console.WriteLine("Lala");
/////

///*
// * til store kodekommentarer
// * */

//#region Menu
////alt muligt imellem, som man kan åbne og lukke.
//#endregion

////ctrl K ctrl s
//#if true
//Console.WriteLine("dette bliver omgivet af noget");
//#endif

//Console.WriteLine("Stik"if (true)
//{

//}
//;

//ctrl D ret kode ind

//lalalalafoarjngjsrbjsRBOJW
//pijglsjdbgkjsbgkjb


#region array, 
//ARRAY multipledimension
int[,] lotto = new int[3, 7]; //tre rækker med 7 tal i hver
int[,] lotto2 = { { 1, 2, 3, 4, 5, 6, 7 }, { 5, 7, 9, 13, 17, 27, 90 }, { 55, 17, 61, 23, 37, 47, 80 } };
Console.WriteLine((lotto2[1, 3])); //udskriver array på indexplads 1, og i dette arry udskriver den på plads nr 4( 0, 1, 2, 3), dvs 13. 

//Array, jagged (takket)
var ja = new int[4][];
ja[0] = new int[] { 1, 2, 3 };
ja[1] = new int[] { 2, 2 };

//skibets position er x,y
int[,] shipPosition = new int[4, 2]; //4 arrays (skibe, som hver har to koordinater) med to positioner i
shipPosition =  new int[3,2]{ { 1, 2 }, { 3, 4 } , { 6, 2} };
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.SetCursorPosition(shipPosition[0,0], shipPosition[2, 1]); //første array, anden værdi
Console.Write("X");
Console.ReadKey();
#endregion