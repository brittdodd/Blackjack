using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//                                                        Decided to go with While, and If else loops to create this because it gave me the opportunity to 
//                                                        do a <, >, <=, >= capabilities where the switch statement would have had to been exact numbers. Even though 
//                                                        you can accomplish the same results with a switch statement, this route was a little more efficient. 
namespace Blackjack
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome to Brittanys Blackjack table!
                                       .:                                       
                                       5G                                       
                                      ?@@5                                      
                                     ?@&&@5                                     
                                   .5@#55B@G:                                   
                                  ~B@PY&@5P@&!                                  
                                :Y@&YP@@@@GY#@P^                                
                       .      .J&@P5&@@@@@@&PP&@Y:                              
               .:^:  !YJB7  .?#@GP#@@@@@@@@@@#PG&&J:  ^G5??  .^:.               
             .7J#5JJ?#~7B7.J#&GP#@@@@@@@@@@@@@@#PP&&Y:^BY.BYJJJBP7^             
             5J~^   7&J~~Y&#PP#@@@@@@@@@@@@@@@@@@&P5#&P!~7&5.  .!~B.            
             ~B&Y^:  B@@@B5G&@@@@@@@@@@@@@@@@@@@@@@&G5B@@@@^ .:7##?             
               ~??~:J@&G5B@@@@@@@@@@@@@@@@@@@@@@@@@@@@B5P&@5^^7J!.              
            :::::~5&@GP#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#GG@&P!:::::            
           :G7!!!7??7J&P777Y@@@@@@@&?77777Y@@@@&P?!!!?PY7?!P@@Y!!!55            
           :G.   ~~   ~?   ~@@@@@@@J       G@@Y:      ~~   J@?   !B:            
           ~B.   #@!  :?   !@@@@@@B.  :.   ~@?        J!   ?J   ~#@B~           
          ?@#.   !!.  7?   !@@@@@@!   G5    Y.    ?GPP@~       ~&GY&@Y          
    ~J!~7P@#B.   ??.  ??   !@@@@@P   !@&~   J.    ?GGG@~       7@@#YG@G?~~?!.   
  ^PPPP!P@GP#.   #@7  :?   !@@@@&^   .::.   !!        Y!   JJ   !&@@PP@B~5GPG!  
 :B7  7@@BY@#.   ~~   :?   .^::7J   ~YJ?J~   77.      !~   Y@?   ~#@@5G@@5  :#! 
 ~&^  ^@@J&@#!~~~^^~~!P5~~~~7!~J!~~~?5&@@#!~~~7!~~?~~~7J~7~?5YY~~^?&@&J@@7   #? 
  ?P: Y@#Y@@@@@@@@@@@@@Y    7@@~      7@@@Y^.     J.  .&&~   J@@@@@@@@5B@P .Y5. 
   ~5G&@G5@@@@@@@@@@@@@Y    7@Y   .    G@!       .Y.  .B~   J@@@@@@@@@PP@@G57   
     7&@BJ@@@@@@@@@@@@@Y    7#.  ^B:   !Y    .?YJPG    .   J@@@@@@@@@@YG@@Y.    
      7@@?B@@@@@@G7^G@@Y    77   5@P   ^7    :G&#&G       .B@@@@@@@@@#7@@Y      
       5@B7&@@@@@7  ~5Y:   .J.   ^~~   .J.     . ^P   .5.  :G@@@@@@@&7G@G.      
        Y@BJ#@@@@G:        7~   ~!~!!   :7:       J   .&G   .P@@@@@#JG@P.       
         7&@PP#@@@#?^:...:7J:::!@GP@@?:::~G5!:..:^5^::^&@5:::^G@@#PP&@J         
          :5&&GPG#@@@&&&&@@@&@&B5G@B#@PBB5@@B@&5G&@@@&@@@@@@&#BGPG&@P^          
           .~5B@&BGPGGB####BBGGB&B7:#@J#&?@&^!G&BGGBB###BBGGGGB&@#57.           
         .Y5~5P~?PB####BBB####GJ^  7@B?@@JB@Y  :?P####BBBB#&&#PJ~JG!JP^         
         !P: ^#^   .:!@@@@B7^.    ^&@?B@@#7&@!    .^!P@@@@Y::    B? .J5         
         :J^ .!..:^^~5@@G!       ~#@JP@@@@G?&@7       ^5@@G7^^:. ~^ .?~         
          .7J??Y5PG#@@G!       :Y@#YB@@@@@@BY#@P^       ^5&@&BP5YJ?J?^          
            ^!777!77!^      :7P&&5Y#&######&#55&@G?^      :~77!!777~.           
                          .Y@@@@#G##BBBBBBBBB#G#@@@@P:                          
                          :!!!!!!!!!!!!!!!!!!!!!!!!!!^                          
");

            Console.WriteLine("Let's go ahead and get started!\n\n");
            Console.WriteLine("You are currently playing against the dealer... Here is your first hand.\n\n");
            int playerCardValue = 0;
            int dealerCardValue = 0;
          

            Random random = new Random();

            playerCardValue += random.Next(1, 12); //This will create a random number from 1-11
            playerCardValue += random.Next(1, 12); 

            if(playerCardValue > 21)
            {
                playerCardValue -= 10;
            }

            dealerCardValue += random.Next(1, 12);
            dealerCardValue += random.Next(1, 12);

            if (dealerCardValue >21)
            {
                dealerCardValue -= 10;
            }

            //**********************************************************************************************************************
            //                                             PLAYER'S TURN
            //**********************************************************************************************************************
            while (true)
            {
                if (playerCardValue == 21)
                {
                    Console.WriteLine("You have 21!!!");
                    break; //The breaks help stop the loop once it has completed the task
                }
              

                Console.WriteLine("Your Card Value is: " + playerCardValue.ToString() + " Would you like to hit?");

                string answer = Console.ReadLine();

                if (answer == "Yes")
                {
                    playerCardValue += random.Next(1, 12); //This will create a random number from 1-11
                    if (playerCardValue > 21)
                    {
                        Console.WriteLine("You busted!");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (answer == "No")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect response, try again");
                    continue;
                }
            }

            //**********************************************************************************************************************
            //                                             DEALER'S TURN
            //**********************************************************************************************************************

            Console.WriteLine("Players card value is " + playerCardValue.ToString());
            if (playerCardValue <= 21)
            {   
                //This while is here because the player has not busted
                while (dealerCardValue < 21 && dealerCardValue < playerCardValue)
                {
                    dealerCardValue += random.Next(1, 12);
                }


                //This if is here to check for a winner
                if (playerCardValue == dealerCardValue)
                {
                    Console.WriteLine("Player and dealer have tied");
                }
                //This is if the players card is less than the dealer and the dealer is still within the 21 limit, the dealer won
                else if (playerCardValue < dealerCardValue && dealerCardValue <= 21)
                {
                    Console.WriteLine("Dealer has won!");
                }
                //This is if the dealer has gone over the 21 limit, than the player has won the game
                else if (dealerCardValue > 21)
                {
                    Console.WriteLine("Dealer has busted, player has won!");
                }
                //This is if the dealer hits 21 but the player is not equal to the dealer and is under 21.
                else if (dealerCardValue == 21)
                {
                    Console.WriteLine("Dealer has won!");
                }

                Console.ReadLine();
            }
        }
    }
}
