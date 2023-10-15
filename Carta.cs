// Crea una clase llamada "Carta".​
class Carta{

  /* Dale a la Carta una propiedad llamada "nombre" que contendrá el valor de la carta
  ej. (As, 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Reina, Rey). Esta propiedad "nombre" debe ser una cadena.​ */
  private string Nombre;
  public string _Nombre{
    get{ return Nombre; }
    set{ Nombre = value; }
  }

  // Dale a la Carta una propiedad llamada "pinta" que contendrá la pinta de la carta (Tréboles, Picas, Corazones, Diamantes).​
  private string Pinta;
  public string _Pinta{
    get{ return Pinta; }
    set{ Pinta = value; }
  }

  // Dale a la Carta una propiedad llamada "val" que contendrá el valor numérico de la tarjeta (1-13) como enteros.​
  private int Val;
  public int _Val{
    get{ return Val; }
    set{ Val = value; }
  }

  public Carta(string nombre, string pinta, int val){
    Nombre = nombre;
    Pinta = pinta;
    Val = val;
  }

  // Añade una función Print a tu clase de cartas que imprima el nombre, valor y pinta de cada carta.​
  public void MostrarCarta(){
    Console.WriteLine($"{Nombre} de {Pinta}, valor de la carta {Val}");
  }
}