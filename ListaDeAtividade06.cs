﻿/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 05/02/2025
 * Hora: 07:38
*/
using System;
namespace ListaAtividade06{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine("\n\n ------ LISTA 06 ------- \nEscolha a atividade: \nA - B - C - D - E - F - G - H - I - J \n   PRESIONE S PARA SAIR");
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
				DateTime dataAtual = DateTime.Now;
				Console.WriteLine(dataAtual);
			}
		
			static void questaoB(){
				Console.WriteLine(" \n------- QUESTAO B ------- \n");
				DateTime primData = DateTime.Now;
				DateTime segData = new DateTime(2001, 08, 16);
				TimeSpan diferenca = primData - segData;
				Console.WriteLine("Voce tem : " + diferenca.Days + " dias de vida!");
			}
			
			static void questaoC(){
				Console.WriteLine(" \n------- QUESTAO C ------- \n");
				Console.Write("Digite seu aniversário: ");
				string data = Console.ReadLine();
				DateTime dataPessoa = DateTime.Parse(data);
				DateTime dataAtual = DateTime.Now;
				int idade = dataAtual.Year - dataPessoa.Year;
				Console.WriteLine("Você tem " + idade);
				
			}
			
			static void questaoD(){
				Console.WriteLine(" \n------- QUESTAO D ------- \n");
                Console.Write("Digite uma data: ");
                string data = Console.ReadLine();
                DateTime dataPessoa = DateTime.Parse(data);
                if (feriadoConfere(dataPessoa)){
                    Console.WriteLine("A data informada é um feriado nacional.");
                }else{
                    Console.WriteLine("A data informada não é um feriado nacional.");
                }
			}

            static bool feriadoConfere(DateTime data){
                string dataFormatada = data.ToString("dd/MM");
            
                switch (dataFormatada){
                    case "01/01": // Ano novo
                    case "21/04": // Tiradentes
                    case "01/05": // Dia do Trabalho
                    case "07/09": // Independência do Brasil
                    case "12/10": // Nossa Senhora Aparecida
                    case "02/11": // Finados
                    case "15/11": // Proclamação da República
                    case "25/12": // Natal
                        return true;
                    default:
                        return false;
                    }
            }
                
			static void questaoE(){
				Console.WriteLine(" \n------- QUESTAO E ------- \n");
				Console.Write("Escolha uma opção (digite 1 2 ou 3): \n 1) - primeira \n 2) - segunda\n 3) - terceira \n opção = ");
				int opcao = int.Parse(Console.ReadLine());
				
				switch (opcao){
					case 1:
						Console.WriteLine("Você escolheu a primeira opção");
						break;
					case 2:
						Console.WriteLine("Você escolheu a segunda opção");
						break;
					case 3:
						Console.WriteLine("Você escolheu a terceira opção");
						break;
					default:
						Console.WriteLine("Opção inválida!");
						break;
				}
					
			}
			
			static void questaoF(){
				Console.WriteLine(" \n------- QUESTAO F ------- \n");
				Console.Write("Digite um valor: ");
				int valor = int.Parse(Console.ReadLine());
				int decisao;
				if(valor == 0){
					decisao = 0;
				}else if(valor > 0){
					decisao = 1;
				}else{
					decisao = 2;
				}
				
				
				switch (decisao){
					case 0:
						Console.WriteLine("Valor zero digitado!");
						break;
					case 1:
						Console.WriteLine("Valor positivo digitado!");
						break;
					case 2:
						Console.WriteLine("Valor negativo digitado!");
						break;
					default:
						Console.WriteLine("Inválido!");
						break;
				}
			}
		
			static void questaoG(){
				Console.WriteLine(" \n------- QUESTAO G ------- \n");
				Console.WriteLine("Escolha uma cor: \nVermelho \nAzul \nVerde \n = ");
				string cor = Console.ReadLine();
				
				switch (cor.ToLower()){
					case "vermelho":
						Console.WriteLine("A cor escolhida foi vermelho!");
						break;
					case "azul":
						Console.WriteLine("A cor escolhida foi Azul!");
						break;
					case "verde":
						Console.WriteLine("A cor escolhida foi verde!");
						break;
					default:
						Console.WriteLine("Inválido!");
						break;
				}
			}
		
			static void questaoH(){
				Console.WriteLine(" \n------- QUESTAO H ------- \n");
				Console.Write("Insira um letra: ");
				Char letra = char.Parse(Console.ReadLine().ToLower());
				int isVogal = 0;
				if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'){
					isVogal = 0;
				}else{
					isVogal = 1;
				}
				
				switch(isVogal){
					case 0:
						Console.WriteLine("Vogal");
						break;
					case 1:
						Console.WriteLine("Consoante");
						break;
					default:
						Console.WriteLine("Erro!");
						break;
				}
			}
		
            static void questaoI(){
                Console.WriteLine(" \n------- QUESTAO I ------- \n");
                Console.WriteLine("Escolha um dia da semana \n1)Segunda \n2)Terça \n3)Quarta \n4)Quinta \n5)Sexta \n6)Sábado \n7 Domingo");
                int dia = int.Parse(Console.ReadLine());
                switch(dia){
                    case 1:
                        Console.WriteLine("O dia escolhido foi: Segunda-Feira");
                        break;
                    case 2:
                        Console.WriteLine("O dia escolhido foi: Terça-Feira");
                        break;
                    case 3:
                        Console.WriteLine("O dia escolhido foi: Quarta-Feira");
                        break;
                    case 4:
                        Console.WriteLine("O dia escolhido foi: Quinta-Feira");
                        break;
                    case 5:
                        Console.WriteLine("O dia escolhido foi: Sexta-Feira");
                        break;
                    case 6:
                        Console.WriteLine("O dia escolhido foi: Sábado");
                        break;
                    case 7:
                        Console.WriteLine("O dia escolhido foi: Domingo");
                        break;
                }
                
            }   

			static void questaoJ(){
				Console.WriteLine(" \n------- QUESTAO J ------- \n");
	            Console.WriteLine("Digite o tamanho que deseja: P, M ou G");
                char tamanho = char.Parse(Console.ReadLine().ToLower());
				
                switch (tamanho){
                    case 'p':
                        Console.WriteLine("P custa: R$50,00");
                    break;
                    case 'm':
                        Console.WriteLine("M custa: R$51,00");
                    break;
                    case 'g':
                        Console.WriteLine("G custa: R$52,00");
                    break;
                    default:
                       Console.WriteLine("Opção inválida!");
                    break;
                }
			}
		
	}
}
