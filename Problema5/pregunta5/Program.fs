// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = float (a / b)

[<EntryPoint>]
let main argumentos = 
    
    Console.WriteLine("Introduzca dos numeros")
    let num1 = Console.ReadLine()
    let num2 = Console.ReadLine()
    let valor1 = Convert.ToInt32(num1)
    let valor2 = Convert.ToInt32(num2)
    let valor3 = suma valor1 valor2
    Console.WriteLine("la suma es: "+valor3.ToString())
    let valor4 = resta valor1 valor2
    Console.WriteLine("la resta es: "+valor4.ToString())
    let valor5 = multiplicacion valor1 valor2
    Console.WriteLine("la multiplicaion es: "+valor5.ToString())
    let valor6 = float (division valor1 valor2)
    Console.WriteLine("la division es: "+valor6.ToString())

    let tecla = Console.ReadKey()
    0 // devolver un código de salida enterover un código de salida entero
