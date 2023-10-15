// ¡Revisa tu trabajo! Ahora instancia una Carta en el archivo Program.cs y asegúrate que el nombre, el valor y la pinta se impriman en la consola.​
Console.WriteLine("-------------------------------\nCreamos una carta y la mostramos\n-------------------------------");
Carta carta1 = new Carta("As", "Pica", 1);
carta1.MostrarCarta();


// ¡Revisa tu trabajo! Ahora instancia un Mazo para que cada carta se imprima en la consola.​
Console.WriteLine("-------------------------------\nCreamos un mazo y lo mostramos\n-------------------------------");
Mazo mazo = new Mazo();
foreach(Carta carta in mazo._Cartas){
  carta.MostrarCarta();
}

// barajamos el mazo
Console.WriteLine("-------------------------------\nBarajamos el mazo\n-------------------------------");
mazo.BarajarMazo();

// repartir 8 cartas
Console.WriteLine("-------------------------------\nRepartimos 8 cartas y las mostramos\n-------------------------------");
for(int i=1; i<=8; i++){
  Carta carta2 = mazo.Repartir();
  carta2.MostrarCarta();
}
Console.WriteLine("-------------------------------\nRevisamos el mazo\n-------------------------------");
foreach(Carta carta in mazo._Cartas){
  carta.MostrarCarta();
}

mazo.RestablecerMazo();
Console.WriteLine("-------------------------------\nRestablecemos el mazo y lo mostramos\n-------------------------------");
foreach(Carta carta in mazo._Cartas){
  carta.MostrarCarta();
}

// barajamos el mazo de nuevo
Console.WriteLine("-------------------------------\nBarajamos el mazo nuevamente\n-------------------------------");
mazo.BarajarMazo();

// Revisa tu trabajo robando tres cartas e imprimiendo la mano del jugador en la consola.​
Jugador jugador1 = new Jugador("Alex");
Console.WriteLine($"-------------------------------\nel jugador {jugador1._Nombre} robó las siguientes cartas\n-------------------------------");
for (int i = 0; i < 3; i++){
  Carta carta = jugador1.RobarCarta(mazo);
}
// jugador1.MostrarMano();

for (int i = 0; i < 3; i++){
  Carta carta = jugador1.RobarCarta(mazo);
}
jugador1.MostrarMano();
Random rand = new Random();
int x = rand.Next(jugador1._Mano.Count());

Carta? cartaDesc = jugador1.DescartarCarta(x);
if(cartaDesc != null){
  Console.WriteLine("-------------------------------\nLa carta descartada es:");
  cartaDesc.MostrarCarta();
  Console.WriteLine("-------------------------------");
}else{
  Console.WriteLine($"-------------------------------\nselecciona una carta de la mano de {jugador1._Nombre}\n-------------------------------");
}

// Revisa tu trabajo imprimiendo la mano del Jugador después de ejecutar el método de descarte.​
Console.WriteLine($"-------------------------------\nMostramos la mano del jugador {jugador1._Nombre}\n-------------------------------");
jugador1.MostrarMano();