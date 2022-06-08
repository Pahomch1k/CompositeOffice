using System;

namespace Dz_10_CompositeOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
             
            //Leaf leaf = new Leaf();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(leaf);
             
            Composite tree1 = new Composite("Приемная");

            TableMagazine branch1 = new TableMagazine();
            for (int i = 0; i < 10; i++) 
                branch1.Add(new Magazine()); 
            
            tree1.Add(branch1);

            tree1.Add(new Divan());

            TableSec branch2 = new TableSec();
            Komp branch3 = new Komp();
            branch3.Add(new HDD());
            branch2.Add(branch3);
            branch2.Add(new Instrument());
            tree1.Add(branch2);

            tree1.Add(new Kyler());


            Composite tree2 = new Composite("Аудитория 2");

            for (int i = 0; i < 10; i++) 
                tree2.Add(new Tablee());

            tree2.Add(new Doska());

            TeacherTable branch4 = new TeacherTable();
            branch4.Add(new Komp());
            tree2.Add(branch4);

            tree2.Add(new Divan());


            Composite tree3 = new Composite("Столовая");
             
            tree3.Add(new CofeAvto());


            Table branch5 = new Table();
            for (int i = 0; i < 4; i++) 
                branch5.Add(new Cheir());

            tree3.Add(branch5);

            tree3.Add(new Frigiretor());

            tree3.Add(new Ymival());


            client.ClientCode(tree1);
            client.ClientCode(tree2);
            client.ClientCode(tree3);


            //Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            //client.ClientCode2(tree1, leaf);
        }
    }
}
