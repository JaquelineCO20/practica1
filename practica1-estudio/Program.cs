//double a = 1;
//float b = 2;
//int c = 4, r = 3;
//char d = '!';
//string e = "abcd";
//string name = "alan", lastname = "flores";
//double sumar(double dato1, double dato2)
//{
//    return dato1 + dato2;
//}
//{ }
//representan el orden en que quiere que se impriman, despues de las comillas se coloca el nombre de la variable 
//que quieres que este en esa posición
//esto se llama COMPOSITE FORMATING
//Console.WriteLine("{0} {1} {2} {3}", a, b, c, r);
//Console.WriteLine("Su apellido es: {0} y su nombre: {1}", lastname, name);
//STRING INTERPOLATION O PLANTILLAS LITERALES
//permite imterpretar código dentro de la cadena 
//Console.WriteLine($"La suma es: {sumar(a,c)}");
//Console.WriteLine($"Su nombre es: {name} y su apellido: {lastname}");
//Console.WriteLine("Su nombre es: " + name + " y su apellido: " + lastname);
//ciclo WHILE
// var infiere un tipo de dato respecto al valor que le asignas a la variable
//var algo = 0;
//while (algo == 3)
//{
//    Console.WriteLine("Es 3");
//    algo++;
//}

//ciclo DO-WHILE
//do
//{
//    Console.WriteLine("Algo no es 4");
//algo++;
//} while (algo == 4) ;
//CODIGO ASCII
//char car=(char)72;
//char A = (char)79;
//char B = (char)76;
//char C = (char)65;
//char D = (char)66;
//char E = (char)66;
//Console.WriteLine($"{car}{A}{B}{C} {D}{E}");

//string[] miArreglo = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
//Console.WriteLine(miArreglo.Length);
//for (int i = 0; i < miArreglo.Length; i++)
//{
//    //Console.WriteLine($"La condicion se cumple porque {i} es menor que 7");
//    Console.WriteLine(miArreglo[i]);
//}
//string[] miArreglo = new string[10];
//Console.WriteLine(miArreglo.Length);
//for (int i = 0; i < miArreglo.Length; i++)
//{
//    //i es la posicion en la que se encuentra el elemento 
//    miArreglo[i] = $"agregue el numero {i}";
//    Console.WriteLine(miArreglo[i]);

//}
string[] miArreglo = new string[10];
Console.WriteLine(miArreglo.Length);
for (int i = 0; i < miArreglo.Length; i++)
{
    string cadena = Console.ReadLine();
    miArreglo[i] = cadena;
}
foreach(string s in miArreglo)
{

    Console.WriteLine(s);
}
