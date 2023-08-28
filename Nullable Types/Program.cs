using System;

//ref link:https://www.youtube.com/watch?v=C-HNcW8lmsk&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=21
//   nullable types -- int?

class MainClass
{
    //static int GetBalanceFromTaxMan()
    static int? GetBalanceFromTaxMan()  // nullable types -- int?
    //static string GetBalanceFromTaxMan()
    {
        //return -1;
        return null;    // error for value types must be reference type or nullable types
    }
    static void Main()
    {
        //int myReturn = GetBalanceFromTaxMan();
        int? myReturn = GetBalanceFromTaxMan();     // nullable types -- int?
        //string myReturn = GetBalanceFromTaxMan();

    }
}