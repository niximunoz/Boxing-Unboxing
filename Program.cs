List<object> ListaObjetos = new List<object>();

// Agregar los valores a la lista
ListaObjetos.Add(7);
ListaObjetos.Add(28);
ListaObjetos.Add(-1);
ListaObjetos.Add(true);
ListaObjetos.Add("chair");

// Imprimir todos los valores en la lista
Console.WriteLine("Valores en lista:");
foreach (object valores in ListaObjetos)
{
    Console.WriteLine(valores);
}
Console.WriteLine("-----------");
for(int i = 0; i< ListaObjetos.Count; i++){
    Console.WriteLine(ListaObjetos[i]);
}

// Variable para almacenar la suma de los valores enteros
int sum = 0;

// Recorrer lista y sumar valores enteros
foreach (object valores in ListaObjetos)
{
    if (valores is int)
    {
        sum += (int)valores;
    }
}
Console.WriteLine("-----------");
// Suma de los valores enteros
Console.WriteLine("Suma de los valores enteros: " + sum);
