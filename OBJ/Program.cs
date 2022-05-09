using static System.Console;
using introdução_obj.src.Entities;

namespace dotnet_poo
{
    class Program
    {

        static void Main(){

                Knight hero = new Knight("Arus",24,"Knight");
                Wizard wizard = new Wizard("Jennica",23,"White Wizard");

              WriteLine(hero.Attack());
              WriteLine(wizard.Attack(9));



        }

    }




}
