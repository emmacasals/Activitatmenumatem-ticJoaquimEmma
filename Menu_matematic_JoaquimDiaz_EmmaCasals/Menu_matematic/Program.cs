﻿/*1.- Menú matemàtic
Fer un menú amb 9 opcions (8 + q per sortir). Cada opció del menú cridarà a una acció Maxim,
Mcd, Mcm, Factorial, Combinatori, MostrarDivisorMajor, EsPrimer, NPrimersPrimers que
demanarà les entrades validades, farà els càlculs, i mostrarà el resultat. Les entrades hauran de
ser validades per algunes de les funcions de validació. Cal presentar un projecte únic amb totes
les funcions i accions proposades a més a més del programa principal que implementa el
menú.*/


//MAIN:Fem la crida de les altres funcions 
static void Main(string[] args)
{

}

//Maxim
static int Maxim(int num)
{
  
}
//Mcd
static int MCD(int num)
{
}
//Mcm
static int MCM(int num)
{
}

//Factorial
//Aquesta es la més correcta
static int Factorial(int num)
{

    int res = 1;
    for (int i = 1; i <= num; i++)
        res *= i;
    return res;
}
/*
static double Factorial(double num)
{

    int res = 1;
    for (int i = 1; i <= num; i++)
        res *= i;
    return res;
}
*/
//COMBINATORI FACTORIAL
static double Combinatori(int n, int m)
{
    double resultat;
    resultat = Factorial(n) / (Factorial(m)) / Factorial(n - m);
    return resultat;
}

//Combinatori
//COMBINATORI FACTORIAL
static double Combinatori(int n, int m)
{
    double resultat;
    resultat = Factorial(n) / (Factorial(m)) / Factorial(n - m);
    return resultat;
}
//MostrarDivisorMajor
static int MCD(int num)
{
}
//EsPrimer
static int EsPrimer(int num)
{
}
//NPrimersPrimers
static double NPrimersPrimers(int n, int m)
{
}
