//alt shift f

using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
    class Program
    {
        public class Guest
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }
        }

        public class GuestTable
        {
            // public string TableName { get; set; }
            public List<Guest> TableGuests { get; set; } = new List<Guest> ();
            //this above is making an emptry array so that we can avoid getting null exeption error 
            //TableGuests = []
        }
        static void Main(string[] args)
        {

            List<Guest> guests = GetAllGuests();

            //    GuestTable MakeTable(guests);

            // foreach (Guest myGuest in guests)
            // {
            //     Console.WriteLine($"{myGuest.Name}");
            // }

            // A function to make and return list of guests
            List<Guest> GetAllGuests()
            {
                // Make a list of Enemy objects
                List<Guest> guests = new List<Guest> {
               new Guest {
                Name = "Marilyn Monroe",
                Occupation = "entertainer",
                Bio = "(1926 - 1962) American actress, singer, model"
                },
               new Guest {
                Name = "Abraham Lincoln",
                Occupation = "politician",
                Bio = "(1809 - 1865) US President during American civil war"
                },
               new Guest {
                Name = "Martin Luther King",
                Occupation = "activist",
                Bio = "(1929 - 1968)  American civil rights campaigner"
                },
               new Guest {
                Name = "Rosa Parks",
                Occupation = "activist",
                Bio = "(1913 - 2005)  American civil rights activist"
                },
               new Guest {
                Name = "Peter Sellers",
                Occupation = "entertainer",
                Bio = "(1925 - 1980) British actor and comedian"
                },
               new Guest {
                Name = "Alan Turing",
                Occupation = "computer scientist",
                Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                },
               new Guest {
                Name = "Admiral Grace Hopper",
                Occupation = "computer scientist",
                Bio = "(1906 - 1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                },
               new Guest {
                Name = "Indira Gandhi",
                Occupation = "politician",
                Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
                }
            };
                return guests;
            }

            GuestTable Table1 = new GuestTable();
            GuestTable Table2 = new GuestTable();

            // try{
            foreach (var guest in guests)
            {

                List<string> table1Occupations = Table1.TableGuests.Select(g => g.Occupation).ToList();

                if (table1Occupations.Contains(guest.Occupation))
                {
                    Table2.TableGuests.Add(guest);
                }
                else
                {
                    
                    Table1.TableGuests.Add(guest);
                }

            // }}catch{
                
            }


            Console.WriteLine("Table 1");
            foreach (Guest myGuest in Table1.TableGuests)
            {
                Console.WriteLine($"{myGuest.Name}");
            }

            Console.WriteLine("Table 2");
            foreach (Guest myGuest in Table2.TableGuests)
            {
                Console.WriteLine($"{myGuest.Name}");
            }
            // Console.WriteLine($"table 2 {Table2}");
            // GuestTable MakeTable(List<Guest> guests)
            //{
            // GuestTable Table1 = new GuestTable();
            // Table1.TableName = "Table 1";

            // GuestTable Table2 = new GuestTable();
            // Table2.TableName = "Table 2";

            // foreach (var guest in guests)
            // {

            //     List<string> table1Occupations = guests.Select(g => g.Occupation).ToList();

            //     if (!table1Occupations.Contains(guest.Occupation))
            //     {
            //         Table2.Guests.Add(guest);
            //     }
            //     else
            //     {
            //         Table1.Guests.Add(guest);
            //     }
            // }
            // return Table1;
            // Console.WriteLine($"{Table1},{Table2}");








        }
    }
}




