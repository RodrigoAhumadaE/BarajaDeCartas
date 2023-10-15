// Crea una clase llamada "Mazo"​
using System.Formats.Asn1;

class Mazo{
  // Dale a la clase Mazo una propiedad llamada "cartas" que es una lista de objetos de Carta.​
  private List<Carta> Cartas = new List<Carta>();
  public List<Carta> _Cartas{
    get{ return Cartas; }
  }

  /* Al inicializar la baraja, asegúrate de que tenga una lista de 52 cartas únicas como propiedad "cartas",
  aunque también se puede escribir .Add e instanciar cada tarjeta por separado. ¡Existe una forma más eficiente
  para hacer esto! Piensa en el patrón del mazo.​ Hay 4 pintas y 13 valores para cada una. ​No te preocupes todavía
  por el nombre de la carta (por ejemplo: As, Sota, Reina). ​Puedes añadir el nombre después de elaborar el patrón.
  Empieza por calcular cómo harías 4 cartas de cada pinta.​ Luego piensa cómo harías 13 cartas para cada uno de esas
  4 pintas, cada una con su propio valor único del 1 al 13.​ Estamos haciendo un conjunto de acciones repetidamente.
  ¿Cómo hacemos algo repetidamente en código?​ */
  List<string> nombreCartas = new List<string>() {"As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Reina", "Rey"};
  List<string> nombrePintas = new List<string>() {"Corazones", "Picas", "Diamantes", "Tréboles"};

  public Mazo(){
    for(int i = 0; i < nombrePintas.Count; i++){
      for(int j = 0; j < nombreCartas.Count; j++){
        Carta carta = new Carta(nombreCartas[j], nombrePintas[i], j+1);
        Cartas.Add(carta);
      }
    }
  }

  // Crea métodos en "Mazo"​
  // Dale al Mazo un método de reparto que seleccione la carta "más alta", la elimine de la lista, y la devuelva.​
  public Carta Repartir(){
    int indice = Cartas.Count() - 1;
    Carta carta = Cartas[indice];
    Cartas.RemoveAt(indice);
    return carta;
  }

  // Dale al Mazo un método de reinicio que restablezca la propiedad Cartas para que contenga las 52 cartas originales.​
  public void RestablecerMazo(){
    Cartas.Clear();
    for(int i = 0; i < nombrePintas.Count(); i++){
      for(int j = 0; j < nombreCartas.Count(); j++){
        Carta carta = new Carta(nombreCartas[j], nombrePintas[i], j+1);
        Cartas.Add(carta);   
      }
    }
  }

  // Dale al mazo un método de barajado que reordene aleatoriamente las cartas del mazo.
  public void BarajarMazo(){
    Random rand = new Random();
    int i = Cartas.Count();
    while(i > 1){
      i--;
      int j = rand.Next(i + 1);
      Carta aux = Cartas[j];
      Cartas[j] = Cartas[i];
      Cartas[i] = aux;
    }
  }
}