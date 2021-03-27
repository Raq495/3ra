using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace g
{

    public class Program 
    {
        public static void Main()
        { string a = "";
            int TamañoPerro = 0;
            int mascota = 0;
            double kg = 0.0;
            int opcion = 0;
            
            
            
            do{
                
                Console.WriteLine("Bienvenidos a diamongs dogs");
                
                Console.WriteLine("Recordemos limpiar las patas de nuestras mascotas");
                
                
                Console.WriteLine("¿Cual es el peso de su mascota?:");
                a = Console.ReadLine();
                kg = Convert.ToDouble(a);
                
                Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - muy imperactivo");
                Console.WriteLine("2 - imperactivo");
                Console.WriteLine("3 - normal");
                a = Console.ReadLine();
                mascota = Convert.ToInt32(a);
                
                
                //Tamaño Miniatura
                if(kg <= 5 && kg >= 2) 
                {
                    
                    switch (mascota) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                            Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 y 100 gramos.");
                            Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                            break;
                        case 3:
                           
                             Console.WriteLine("Su perro debe comer entre 45 -85 gramos.");
                           Console.WriteLine("la porcion hiria aumentado 9% mesualmente"); break;
                            
                        
                    }
                    
                }  
                //pequeño
                 else if (kg <= 10 && kg >=5 ) 
                {
                    
                    switch (mascota) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115 - 190 gramos de alimento.");
                            Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100 y 170 gramos.");
                           Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                             break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85 -145 gramos.");
                          Console.WriteLine("la porcion hiria aumentado 9% mesualmente");  break;
                    }
                    
                }
                
                //mediano
                else if (kg <= 15 && kg >= 10 ) 
                {
                    
                    switch (mascota) {
                        case 1:
                           Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                             Console.WriteLine("Su perro debe comer entre 190 - 255 gramos de alimento.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170 y 225 gramos.");
                          Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                              break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145 -195 gramos.");
                          Console.WriteLine("la porcion hiria aumentado 9% mesualmente");  break;
                    }
                    
                }
                                //Tamaño grande 15
                if(kg <= 25 && kg >= 15) 
                {
                    
                    switch (mascota) {
                       case 1:
                            Console.WriteLine("Su perro debe comer entre 255- 330 gramos de alimento.");
                           Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                             break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225 y 300 gramos.");
                           Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                             break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195 -285 gramos.");
                          Console.WriteLine("la porcion hiria aumentado 9% mesualmente");  break;
                    }
                }  
                //grande 25
                 else if (kg <= 40 && kg >=25 ) 
                {
                    
                    switch (mascota) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 380 - 535 gramos de alimento.");
                           Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                             break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 330 -475 gramos.");
                          Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                              break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 285 -410 gramos.");
                        Console.WriteLine("la porcion hiria aumentado 9% mesualmente");    break;
                    }
                    
                }
                
                //grande 40
                else if (kg <= 55 && kg >= 40 ) 
                {
                    
                    switch (mascota) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 535 - 680 gramos de alimento.");
                           Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                             break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 475 y 600 gramos.");
                          Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                              break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 410 -520 gramos.");
                         Console.WriteLine("la porcion hiria aumentado 9% mesualmente");   break;
                    }
                    
                }
                
                                //Tamaño grande 55
                if(kg <= 70 && kg >= 55 ) 
                {
                    
                    switch (mascota) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 680 - 820 gramos de alimento.");
                            Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 600 y 720 gramos.");
                           Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                             break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 520 -620 gramos.");
                         Console.WriteLine("la porcion hiria aumentado 9% mesualmente");   break;
                    }
                }  
                //grande 70
                 else if (kg <= 90 && kg >=70 ) 
                {
                    
                    switch (mascota) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 820 - 985 gramos de alimento.");
                           Console.WriteLine("la porcion hiria aumentado 10.2% mesualmente");
                             break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 720 -870 gramos.");
                         Console.WriteLine("la porcion hiria aumentado 10.1% mesualmente");
                               break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 620 -750 gramos.");
                         Console.WriteLine("la porcion hiria aumentado 9% mesualmente");   break;
                    }
                    
                }
                

                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                a = Console.ReadLine();
                opcion = Convert.ToInt32(a);
                
                Console.Clear();
                
                
            }while(opcion != 4);
			
        }
    }
}