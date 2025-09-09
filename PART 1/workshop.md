## Syntax, Semantics
1. Error semántico
    ```
    x = "3" + 2
    ```
    - Dependiendo del lenguaje de programacion, no será posible efectuar operaciones entre dos tipos de datos distintos como lo es una cadena y un enetro.
2. Error semántico
    ```
    int age = "twenty"
    ```
    - La sintaxis es correcta, pero semanticamente es incorrecto asginar una cadena de texto a una variable de tipo entero.
3. Error semántico
    ```
    int x;
    Console.WriteLine(x);
    ```
    - La sintaxis es válida, pero usar una variable no inicializada viola las reglas semánticas del lenguaje.
4. Error de sintaxis
    ```
    int num = 5
    printf("%d",num)
    ```
    - Hace falta un `;` despues de inicializar `num`
## Pragmatics
1. Pragmaticamente incorrecto
    ```
    class Calculator{
        public static void main(String[] args){
            System.out.println("Sum: " + (2*3))
        }
    }
    ```
    - Una calculadora deberia poder ejecutar mas funcionalidades, como lo son la suma, la multiplicacion y la division. En este programa, no se aprovecha el paradigma orientado a objetos para abstraer y modularizar dichas funcionalidades, lo que hace pragmaticamente incorrecto esta implementacion de la calculadora.
2. Pragmaticamente Incorrecto
    ```
    password = "1234"
    print("Your password is: ",password)
    ```
    - Desde un punto de vista de seguridad, es pragmaticamente incorrecto mostrar una constraseña en texto plano, sin encriptarlas o usar otro metodo para proteger esta informacion sensible.