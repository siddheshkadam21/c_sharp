// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start");
Console.WriteLine("Code Running");

Console.Write("Helllwo");
Console.Write("Helllwo second time ");

//doing addition and printing it
Console.WriteLine(5+5);

//variables

int num_var = 10; //int
string str_var = "ASDvfg"; //string
double do_var = 9.999;
char char_var = 'S';
bool bool_var = false;

Console.WriteLine(num_var);
Console.WriteLine(str_var);
Console.WriteLine(do_var);
Console.WriteLine(char_var);
Console.WriteLine(bool_var);

//constant
const int numC_var = 100;
//numC_var = 99;

Console.WriteLine("constant variable cant overwrite "+numC_var);

//display variable
string str_var2 = "Data";
Console.WriteLine(str_var+str_var2);
Console.WriteLine(num_var + do_var);

//multiple variables
int x = 10, y = 100, z = 20;
Console.WriteLine(x+y+z);

//all variables are identifires

//type casting
//converted int variable into double
//Implicit casting
int int_var = 99;
double double_var = int_var;
Console.WriteLine("Actual Int variable "+int_var);
Console.WriteLine("Int variable assign to double data type variable"+double_var);

// converted double variable into int
// Explicit casting
double dubVar = 99.99;
int convar = (int)dubVar;
Console.WriteLine("Actual Double data type variable "+dubVar);
Console.WriteLine("Double data type varible converted into int"+convar);

Console.WriteLine(Convert.ToString(int_var));
Console.WriteLine(Convert.ToDouble(int_var));
Console.WriteLine(Convert.ToInt32(dubVar));
Console.WriteLine(Convert.ToString(bool_var));





