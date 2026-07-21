using System.Runtime.CompilerServices;

int notaFinal = 5;

int[] notasCaro = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] notasLia = new int[] { 92, 89, 81, 96, 90, 89 };
int[] notasClara = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] notasGema = new int[] { 90, 95, 87, 88, 96, 96 };
int[] notasLore = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] notasPily = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] notasBerna = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] notasIvan = new int[] { 91, 91, 91, 91, 91, 91, 91 };   


string[] alumnos = new string[] {"Caro", "Lia", "Clara", "Gema", "Lore", "Pily", "Berna", "Ivan"};

int[] matrizDinamica = new int[10];
int sumaCalificaciones = 0;
decimal gradoActual = 0;
string letraGrado = "";
int adicional = 1;
Console.WriteLine("Estudiante\t Grado\n");

foreach(string nombres in alumnos)
{
    
    if(nombres == "Caro")
    matrizDinamica = notasCaro;
    else if (nombres == "Lia")
    matrizDinamica = notasLia;
    else if (nombres == "Clara")
    matrizDinamica = notasClara;
    else if (nombres == "Gema")
    matrizDinamica = notasGema;
    else if(nombres == "Lore")
    matrizDinamica = notasLore;
    else if (nombres == "Pily")
    matrizDinamica = notasPily;
    else if (nombres == "Berna")
    matrizDinamica = notasBerna;
    else if (nombres == "Ivan")
    matrizDinamica = notasIvan;

    sumaCalificaciones = 0;

    foreach (int notas in matrizDinamica)
        {
            if (adicional <= notaFinal)
                sumaCalificaciones+=notas;
                else
                sumaCalificaciones+=notas/10;
            adicional++;

        }
        adicional = 1;
        gradoActual = (decimal)sumaCalificaciones / notaFinal;

        if (gradoActual >= 97)
        letraGrado = "A+";

        else if (gradoActual >= 93)
            letraGrado = "A";

        else if (gradoActual >= 90)
            letraGrado = "A-";

        else if (gradoActual >= 87)
            letraGrado = "B+";

        else if (gradoActual >= 83)
            letraGrado = "B";

        else if (gradoActual >= 80)
            letraGrado = "B-";

        else if (gradoActual >= 77)
            letraGrado = "C+";

        else if (gradoActual >= 73)
            letraGrado = "C";

        else if (gradoActual >= 70)
            letraGrado = "C-";

        else if (gradoActual >= 67)
            letraGrado = "D+";

        else if (gradoActual >= 63)
            letraGrado = "D";

        else if (gradoActual >= 60)
            letraGrado = "D-";

        else
            letraGrado = "F";

        Console.WriteLine($"{nombres}\t\t {gradoActual}\t{letraGrado}");

}
    Console.WriteLine("Presione la tecla Enter para continuar");
    Console.ReadLine();