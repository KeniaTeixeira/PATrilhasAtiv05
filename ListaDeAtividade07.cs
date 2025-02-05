/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 05/02/2025
 * Hora: 15:36
*/
using System;
namespace ListaAtividade07{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine("\n\n ------ LISTA 07 ------- \nEscolha a atividade: \nA - B - C - D - E - F - G - H - I - J - K - L\n   PRESIONE S PARA SAIR");
			char x = Convert.ToChar(Console.ReadLine());
			char escolha = char.ToLower(x);
			switch(escolha){
					case 'a':
						questaoA();
					break;
					
					case 'b':
						questaoB();
						break;
					
					case 'c':
						questaoC();
						break;
					
					case 'd':
						questaoD();
						break;
						
					case 'e':
						questaoE();
						break;
						
					case 'f':
						questaoF();
						break;
						
					case 'g':
						questaoG();
						break;
						
					case 'h':
						questaoH();
						break;
						
					case 'i':
						questaoI();
						break;
						
					case 'j':
						questaoJ();
						break;
                    
                    case 'k':
						questaoK();
						break;
                    
                    case 'l':
						questaoL();
						break;
						
					case 's':
					sair = 0;
					break;
					
					default:
						Console.WriteLine("Opção Invalida!!");
					break;
					}	
			}
			
			Console.Write("Precione qualquer tecla para continuar . . . ");
			Console.ReadKey(true);
		}
		
			static void questaoA(){
				Console.WriteLine("\n ------- QUESTAO A ------- \n");
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                int i = 0;
                Console.WriteLine("Valores pares de 0 à " + x);
                while (i <= x){
                    if(i%2 == 0){
                        Console.WriteLine(i);
                    }
                    i++;
                }
			}
		
			static void questaoB(){
				Console.WriteLine(" \n------- QUESTAO B ------- \n");
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                int i = 1;

                Console.WriteLine("TABUADA DO " + x );
                while (i <= 10){
                    Console.WriteLine(x + " x " + i + " = " + (x*i));
                    i++;
                }
			}
			
			static void questaoC(){
				Console.WriteLine(" \n------- QUESTAO C ------- \n");
                int valores, total = 0;
                string i = "";

                while (i != "s"){
                    Console.Write("Digite um valor: ");
                    valores = int.Parse(Console.ReadLine());
                    total += valores;
                    Console.Write("Digite s para parar ou qualquer letra para continuar: ");
                    i = Console.ReadLine().ToLower();  
                }

                Console.Write("A soma dos valores digitados: " + total);
			}
			
			static void questaoD(){
				Console.WriteLine(" \n------- QUESTAO D ------- \n");
                int tentativa = 3;

                while (tentativa != 0){
                    Console.Write("Digite a senha: ");
                    string senha = Console.ReadLine();

                    if(senha == "morango"){
                        Console.Write("Senha correta! Sucesso!");
                        tentativa = 0;
                    }else{
                        tentativa--;
                        Console.WriteLine("Senha incorreta! " + tentativa + " tentativas restantes");
                        
                    }
                }
			}
                
			static void questaoE(){
				Console.WriteLine(" \n------- QUESTAO E ------- \n");
                int valores = 0; int total = 0;

                while (valores >= 0){
                    Console.Write("Digite um valor positivo para continuar: ");
                    total += valores;
                    valores = int.Parse(Console.ReadLine());   
                }

                Console.Write("A soma dos valores digitados: " + total);
			
			}
			
			static void questaoF(){
				Console.WriteLine(" \n------- QUESTAO F ------- \n");
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                int i = 0;
                Console.WriteLine("Valores pares de 0 à " + x);

                do{
                    if(i%2 == 0){
                        Console.WriteLine(i);
                    }
                    i++;
                } while (i <= x);
			}
		
			static void questaoG(){
				Console.WriteLine(" \n------- QUESTAO G ------- \n");
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                int i = 0;
                Console.WriteLine("Valores pares de 0 à " + x);

                do{
                    if(i%2 == 0){
                        Console.WriteLine(i);
                    }
                    i++;
                } while (i <= x);
			}
		
			static void questaoH(){
				Console.WriteLine(" \n------- QUESTAO H ------- \n");
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                int i = 1;

                Console.WriteLine("TABUADA DO " + x );
                do{
                    Console.WriteLine(x + " x " + i + " = " + (x*i));
                    i++; 
                } while (i <= 10);
			}
		
            static void questaoI(){
                Console.WriteLine(" \n------- QUESTAO I ------- \n");
                int valores, total = 0;
                string i = "";

                do{
                    Console.Write("Digite um valor: ");
                    valores = int.Parse(Console.ReadLine());
                    total += valores;
                    Console.Write("Digite s para parar ou qualquer tecla para continuar: ");
                    i = Console.ReadLine().ToLower(); 
                    
                } while (i != "s");

                Console.Write("A soma dos valores digitados: " + total);
            }   

			static void questaoJ(){
				Console.WriteLine(" \n------- QUESTAO J ------- \n");
                int tentativa = 3;
                do{
                    Console.Write("Digite a senha: ");
                    string senha = Console.ReadLine();

                    if(senha == "Abacate123"){
                        Console.Write("Senha correta! Sucesso!");
                        tentativa = 0;
                    }else{
                        tentativa--;
                        Console.WriteLine("Senha incorreta! " + tentativa + " tentativas restantes");
                        
                    }
                } while (tentativa != 0);
			}
			static void questaoK(){
				Console.WriteLine(" \n------- QUESTAO K ------- \n");
                int valores = 0; int total = 0;

                do{
                    Console.Write("Digite um valor positivo para continuar: ");
                    total += valores;
                    valores = int.Parse(Console.ReadLine());
                } while (valores > 0);

                Console.Write("A soma dos valores digitados: " + total);
			
			}

            static void questaoL(){
				Console.WriteLine(" \n------- QUESTAO L ------- \n");
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                int i = 0;
                Console.WriteLine("Valores pares de 0 à " + x);

                do{
                    if(i%2 == 0){
                        Console.WriteLine(i);
                    }
                    i++;
                } while (i <= x);
			}
	}
}
