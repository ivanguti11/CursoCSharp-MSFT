using System.Runtime.CompilerServices;

int cantidadNotas = 5;

int[] notasCaro = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] notasLia = new int[] { 92, 89, 81, 96, 90, 89 };
int[] notasClara = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] notasGema = new int[] { 90, 95, 87, 88, 96, 96 }; 


string[] alumnos = new string[] {"Caro", "Lia", "Clara", "Gema"};

int[] matrizDinamica = new int[10];
decimal sumaCalificaciones;
decimal gradoActual = 0;
string letraGrado = "";
int adicional = 1;
decimal examen =0;
decimal examenFinal=0;
decimal extras = 0 ;
Console.WriteLine("Estudiante\t Nota Examen\t Nota General\t Nota Extra\n");

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

    sumaCalificaciones = 0;

    foreach (int notas in matrizDinamica)
        {
            if (adicional <= cantidadNotas)
            {
            sumaCalificaciones+=notas;
            examen+=notas;
            }
                else
                sumaCalificaciones+=(decimal)notas/10;
            adicional++;

        }
        adicional = 1;
        gradoActual = (decimal)sumaCalificaciones / cantidadNotas;
        examenFinal = examen /cantidadNotas;
        extras = gradoActual -examenFinal;

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

        Console.WriteLine($"{nombres}\t\t {examenFinal}\t\t{gradoActual}\t{letraGrado}\t {(int)examenFinal}({extras}) pts");
        examen =0;

}
    Console.WriteLine("Presione la tecla Enter para continuar");
    Console.ReadLine();