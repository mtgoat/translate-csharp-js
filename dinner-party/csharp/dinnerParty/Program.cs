using System;
using System.Collections.Generic;
using System.Linq;

// namespace DinnerParty
// {
//     class Program 
//     {
//         static void Main (string[] args)
//         {
             

        Console.WriteLine("Hello, World!");
        
    

        GuestTable MakeTableList(List<Guest> allGuests)
        {
            GuestTable Table1 = new GuestTable ();

            return Table1;
        }
        
        List<Guest> allGuests = GetAllGuests();
        MakeTableList(allGuests);

        List <Guest> GetAllGuests ()
        {
            List<Guest> allGuests = new List<Guest> (){
                new Guest () {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
                },
                new Guest () {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
                },
                new Guest () {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"    
                },
                new Guest () {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"    
                },
                new Guest () {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"   
                },
                new Guest () {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
                new Guest () {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"    
                },
                new Guest () {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                }
            }; 
                return allGuests;
            }
        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
        }  
        
       
        public class GuestTable
        {
            public string TableName {get; set; }
            public List<string> Guests {get; set; }
        }
//         }
//     }
// };


