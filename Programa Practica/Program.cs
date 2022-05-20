using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Practica
{
    class Program
    {
        //inicio de clase
        class Alumno
        {
            //declaracion de campos
            public string nombre_s, apellidos, correo;
            public byte edad;
            public string[] materias = new string[3];

            //Creacion de constructor 
            public Alumno(string nombre_s, string apellidos, string correo, byte edad, string[] materias)
            {
                //asignación de valores a los campos
                this.nombre_s = nombre_s;
                this.apellidos = apellidos;
                this.correo = correo;
                this.edad = edad;
                this.materias = materias;
            }

            //Impresion de datos
            public void ImpresionDatos()
            {
                Console.WriteLine("LOS DATOS DEL ALUMNO SON: ");
                Console.WriteLine("→ Nombre(s): {0}" +
                                  "\n→ Apellidos: {1}" +
                                  "\n→ Correo: {2}" +
                                  "\n→ Edad: {3}", this.nombre_s, this.apellidos, this.correo, this.edad);
                //materias
                int n = 1;
                for (int i = 0; i < 3; i++)
                {
                    
                    Console.WriteLine("→ Materia {0}: ",n + materias[i]);
                    n++;
                }

            }

            //Modificar MENU
            public byte MenuModificar()
            {
                Console.WriteLine("¿Qué dato decea modificar?" +
                                              "\n1) Nombre(s)" +
                                              "\n2) Apellidos" +
                                              "\n3) Edad" +
                                              "\n4) Correo" +
                                              "\n5) Materias" +
                                              "\n6) Todos");
                Console.Write("Ingrese el numero de la opcion deceada: ");
                Console.Clear();
                return byte.Parse(Console.ReadLine());;
            }

            //Modificar NOMBRE(S)
            public void ModificarNombres()
            {
                Console.Write("Rescribiendo Nombre(s) : ");//nombre
                this.nombre_s = Console.ReadLine();
            }

            //Modificar APELLIDOS
            public void ModificarApellidos()
            {
                Console.Write("Apellidos: ");//apellidos
                this.apellidos = Console.ReadLine();
            }

            //Modificar EDAD
            public void ModificarEdad()
            {
                Console.Write("Edad: ");//edad
                this.edad = byte.Parse(Console.ReadLine());
            }

            //Modificar CORREO
            public void ModificarCorreo()
            {
                Console.Write("Correo: ");//correo
                this.correo = Console.ReadLine();
            }

            //Modificar MATERIASSSS
            public void ModificarMaterias()
            {
                Console.WriteLine("a)Modificar todas las materias:" +
                                  "\nb)Modificar una materia en espesifico");
                Console.Write("Ingrese la opcion deseada: ");
                char modifi = char.Parse(Console.ReadLine());
               
                        int n = 1;
                switch (modifi)
                {
                    case 'a':
                        //materias
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write("Materia {0}: ", n);
                            materias[i] = Console.ReadLine();
                            n++;
                        }
                        break;
                    case 'b':
                        Console.WriteLine("Materias del alumno: {0} {1}",this.nombre_s, this.apellidos);
                         //materias
                        for (int i = 0; i < 6; i++)
                        {
                            
                            Console.WriteLine("Materia {0}: ",n + materias[i] );
                            n++;
                        }
                        Console.Write("Ingrese el número de la materia que decea modificar: ");
                        byte Modificar = byte.Parse(Console.ReadLine());
                        Console.Write("Ingrese la nueva materia de la posicion {0}: ", Modificar);
                        string newmateria = Console.ReadLine();
                        this.materias[Modificar-1] = newmateria;

                        break;

                }

                
            }

            //DESTRUCTOR
            ~Alumno()
            {
                Console.WriteLine("Memoria del objeto ");
            }  
        }


        static void Main(string[] args)
        {
            //declaracion de variables
            int op = 0;

            string[] materias = new string[3] { "POO", "Algebra", "Peru"};
            //creacion de objeto 1
            Alumno alumno1 = new Alumno("Karla Judith", "Santos Rivera", "santoskarla122308@gmail.com",
                                    18, materias);
            //creacion de objeto 2
            Alumno alumno2 = new Alumno("Edwin", "Villada Domingez", "l21212063@tectijuana.edu.mx",
                                    22, materias);

            //MOSTRAR los DATOS en memoria
             Console.WriteLine("ALUMNO 1: ");
             alumno1.ImpresionDatos();

             Console.WriteLine("\nALUMNO 2: ");
             alumno2.ImpresionDatos();

            do
            {
                Console.WriteLine("\n¿Desea modificar algun dato?" +
                              "\n1) Si" +
                              "\n2) No");
                Console.Write("Ingrese el numero la opcion deseada: ");
                op = byte.Parse(Console.ReadLine());

                Console.Clear();
                if (op == 1)
                {
                    Console.WriteLine("Modificar datos:" +
                                      "\na)Alumno 1" +
                                      "\nb)Alumno 2");
                    Console.Write("Ingrese la opcion deseada: ");
                    char alumno = char.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (alumno)
                    {
                        case 'a':
                            byte dato = alumno1.MenuModificar();
                            switch (dato)
                            {
                                case 1:
                                    alumno1.ModificarNombres();
                                    break;
                                case 2:
                                    alumno1.ModificarApellidos();
                                    break;
                                case 3:
                                    alumno1.ModificarEdad();
                                    break;
                                case 4:
                                    alumno1.ModificarCorreo();
                                    break;
                                case 5:
                                    alumno1.ModificarMaterias();
                                    break;
                                case 6:
                                    Console.WriteLine("Modificar todos los datos:");
                                    alumno1.ModificarNombres();
                                    alumno1.ModificarApellidos();
                                    alumno1.ModificarEdad();
                                    alumno1.ModificarCorreo();
                                    alumno1.ModificarMaterias();
                                    break;
                            }
                            break;
                        case 'b':
                            byte valor = alumno2.MenuModificar();
                            switch (valor)
                            {
                                case 1:
                                    alumno2.ModificarNombres();
                                    break;
                                case 2:
                                    alumno2.ModificarApellidos();
                                    break;
                                case 3:
                                    alumno2.ModificarEdad();
                                    break;
                                case 4:
                                    alumno2.ModificarCorreo();
                                    break;
                                case 5:
                                    alumno2.ModificarMaterias();
                                    break;
                                case 6:
                                    Console.WriteLine("Modificar todos los datos:");
                                    alumno2.ModificarNombres();
                                    alumno2.ModificarApellidos();
                                    alumno2.ModificarEdad();
                                    alumno2.ModificarCorreo();
                                    alumno2.ModificarMaterias();
                                    break;
                            }
                            break;

                    }
                }
                else if(op==2)
                {
                    Console.WriteLine("Presione enter para continuar");
                }
            } while (op != 2);
            
        }
    }
}
            ////declaracion de variables
            //string nombre_s, apellidos, correo;
            //byte edad, op;
            //

            ////Obtencion de datos 
            //Console.WriteLine("Bienvenido. Favor de ingresar los sig. datos.");
            //Console.Write("Nombre(s): ");//nombre
            //nombre_s = Console.ReadLine();
            //Console.Write("Apellidos: ");//apellidos
            //apellidos = Console.ReadLine();
            //Console.Write("Edad: ");//edad
            //edad = byte.Parse(Console.ReadLine());
            //Console.Write("Correo: ");//correo
            //correo = Console.ReadLine();

            ////materias
            //for(int i = 0; i < 6; i++)
            //{
            //    int n=1;
            //    Console.Write("Materia {0}: ",n);
            //    materias[i] = Console.ReadLine();
            //    n++;
            //}