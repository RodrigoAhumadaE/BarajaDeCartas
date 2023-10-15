// Crea una clase llamada "Jugador"​
class Jugador{

  // Dale a la clase Jugador una propiedad nombre.​
  private string Nombre;
  public string _Nombre{
    get{ return Nombre; }
    set{ Nombre = value; }
  }

  // Dale al Jugador una propiedad de mano que sea una Lista de tipo Carta.​
  private List<Carta> Mano = new List<Carta>();
  public List<Carta> _Mano{
    get{ return Mano; }
  }

  // constructor
  public Jugador(string nombre){
    Nombre = nombre;
  }

  /* Dale al Jugador un método de robo en el que roba una carta de la baraja, se añada a la mano del jugador, y devuelve la Carta.
  Nota: este método requerirá una referencia a un objeto mazo. */
  public Carta RobarCarta(Mazo mazo){
    Carta carta = mazo.Repartir();
    Mano.Add(carta);
    return carta;
  }

  public void MostrarMano(){
    foreach (Carta carta in _Mano){
      carta.MostrarCarta();
    }
  }

  /* Dale al Jugador un método de descarte que descarta la Carta en el índice especificado de la mano del jugador y devuelve esa Carta
  o null si el índice no existe.​*/
  public Carta? DescartarCarta(int indice){
    if(indice > 0 && indice < _Mano.Count()){
      Carta carta = _Mano[indice];
      _Mano.RemoveAt(indice);
      return carta;
    }else{
      return null;
    }
  }
}