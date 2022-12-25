using System;

class Program
{
    static void Main(string[] args)
    {


        //Değerleri tanımladık

        int AX;
        int AY;
        int Ahealth;
        int Aset;
        int BX;
        int BY;
        int Bhealth;
        int Bset;
        int CX;
        int CY;
        int Chealth;
        int Cset;



        // A oyuncusunu oluşturduk. Kullanıcıdan koordinat girmesini istedik
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Archery Game!");


        Console.WriteLine("Enter the location of A: ");
        Console.Write("AX: ");

        AX = Convert.ToInt16(Console.ReadLine());
        Console.Write("AY: ");
        AY = Convert.ToInt16(Console.ReadLine());


        if ((-10 > AX || AX > 10) || (-10 > AY || AY > 10)) // girilen koordinatlar şartı sağlamazsa program kapanıyor.
        {
            Console.WriteLine("You can't enter this value!");
        }

        else //program devam ediyor
        {

            Random rnd = new Random();
            Aset = rnd.Next(1, 4);
            Ahealth = rnd.Next(3, 6) * 20;

            Console.WriteLine("A : " + "(" + AX + "," + AY + ")  " + "Set " + Aset + "   Health: " + Ahealth);




            // B okçusunun özelliklerini girdik.

            //b'ye rastgele set
            Bset = rnd.Next(1, 4);
            if (Aset == 1)
            {
                Bset = rnd.Next(2, 4);
            }

            else if (Aset == 3)
            {
                Bset = rnd.Next(1, 3);
            }

            else if (Aset == 2) // A 2 alırsa "gecici" adında yeni bir değişken tanımlayıp değişkenin %50 durumuna göre set veriyoruz
            {
                int gecici = rnd.Next(0, 2);
                if (gecici == 0)
                {
                    Bset = 1;
                }

                else
                {
                    Bset = 3;
                }
            }


            //b'ye rastgele health
            Bhealth = rnd.Next(3, 6) * 20;

            if (Ahealth == 60)
            {
                Bhealth = rnd.Next(4, 6) * 20;
            }

            else if (Ahealth == 100)
            {
                Bhealth = rnd.Next(3, 5) * 20;
            }

            else if (Ahealth == 80) // A 80 alırsa "gecici" adında yeni bir değişken tanımlayıp değişkenin %50 durumuna göre health veriyoruz
            {
                int gecici = rnd.Next(0, 2);
                if (gecici == 0)
                {
                    Bhealth = 60;
                }

                else
                {
                    Bhealth = 100;
                }
            }

            //b'ye rastgele koordinatlar
            Random rndcoordinate = new Random();
            BX = rndcoordinate.Next(-10, 11);
            BY = rndcoordinate.Next(-10, 11);
            Console.WriteLine("B : " + "(" + BX + "," + BY + ") " + "Set " + Bset + "   Health: " + Bhealth);



            // C okçusunun özelliklerini girdik.

            Cset = rnd.Next(1, 4);
            if ((Aset == 1 && Bset == 2) || (Aset == 2 && Bset == 1))
            {
                Cset = 3;
            }

            else if ((Aset == 1 && Bset == 3) || (Aset == 3 && Bset == 1))
            {
                Cset = 2;
            }

            else if ((Aset == 2 && Bset == 3) || (Aset == 3 && Bset == 2))
            {
                Cset = 1;
            }



            //c'ye rastgele health

            Chealth = rnd.Next(3, 6) * 20;

            if ((Ahealth == 60 && Bhealth == 80) || (Ahealth == 80 && Bhealth == 60))
            {
                Chealth = 100;
            }

            else if ((Ahealth == 60 && Bhealth == 100) || (Ahealth == 100 && Bhealth == 60))
            {
                Chealth = 80;
            }

            else if ((Ahealth == 80 && Bhealth == 100) || (Ahealth == 100 && Bhealth == 80))
            {
                Chealth = 60;
            }



            //c'ye rastgele koordinatlar

            CX = rndcoordinate.Next(-10, 11);
            CY = rndcoordinate.Next(-10, 11);
            Console.WriteLine("C : " + "(" + CX + "," + CY + ") " + "Set " + Cset + "   Health: " + Chealth);

            Console.ResetColor();

            // random koordinatlar aynı çıkarsa sistemi kapat
            if ((AX - BX == 0 && AY - BY == 0) || (AX - CX == 0 && AY - CY == 0) || (CX - BX == 0 && CY - BY == 0))
                Console.WriteLine("Try again!..");


            else  // değilse devam et
            {


                //koordinat
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("   +---------------------+");
                Console.WriteLine(" 10|..........|..........|");
                Console.WriteLine("  9|..........|..........|");
                Console.WriteLine("  8|..........|..........|");
                Console.WriteLine("  7|..........|..........|");
                Console.WriteLine("  6|..........|..........|");
                Console.WriteLine("  5|..........|..........|");
                Console.WriteLine("  4|..........|..........|");
                Console.WriteLine("  3|..........|..........|");
                Console.WriteLine("  2|..........|..........|");
                Console.WriteLine("  1|..........|..........|");
                Console.WriteLine("  0|----------+---------->");
                Console.WriteLine(" -1|..........|..........|");
                Console.WriteLine(" -2|..........|..........|");
                Console.WriteLine(" -3|..........|..........|");
                Console.WriteLine(" -4|..........|..........|");
                Console.WriteLine(" -5|..........|..........|");
                Console.WriteLine(" -6|..........|..........|");
                Console.WriteLine(" -7|..........|..........|");
                Console.WriteLine(" -8|..........|..........|");
                Console.WriteLine(" -9|..........|..........|");
                Console.WriteLine("-10|..........|..........|");
                Console.WriteLine("   +---------------------+");
                Console.WriteLine("    098765432101234567890");
                Console.ResetColor();



                Console.SetCursorPosition(AX + 14, Math.Abs(AY - 18));
                Console.WriteLine("A");

                Console.SetCursorPosition(BX + 14, Math.Abs(BY - 18));
                Console.WriteLine("B");

                Console.SetCursorPosition(CX + 14, Math.Abs(CY - 18));
                Console.WriteLine("C");


                Console.SetCursorPosition(0, Math.Abs(-32)); // round 1 ve round 2'nin koordinatın altına yazılmasını sağladık.

                Console.ForegroundColor = ConsoleColor.Cyan;


                int abX = AX - BX;
                int abY = AY - BY;
                double distanceab = Math.Sqrt((abX * abX) + (abY * abY));



                int bcX = BX - CX;
                int bcY = BY - CY;
                double distancebc = Math.Sqrt((bcX * bcX) + (bcY * bcY));



                int caX = AX - CX;
                int caY = AY - CY;
                double distanceca = Math.Sqrt((caX * caX) + (caY * caY));

                if (distanceab - distancebc == 0 && distanceab - distanceca == 0 && distancebc - distanceca == 0) // eğer 3ünün arasındaki öklid mesafeleri eşitse sistem kapansin
                    Console.WriteLine("Try again!..");


                else //mesafelerde eşitlik yoksa devam etsin.
                {
                    double min = distanceab; //hangi okçu arası mesafe en kısaysa onu min'e eşitledik. 
                    if (distancebc < min)
                    {
                        min = distancebc;
                    }
                    if (distanceca < min)
                    {
                        min = distanceca;
                    }

                    if (min == distanceab) // ab savaşıyor
                    {
                        if (distanceab > 15)
                        {
                            Console.WriteLine("ROUND 1 : A-B");
                            Console.WriteLine("Too Distant, No Attack");
                        }
                        else
                        {
                            Console.WriteLine("ROUND 1 : A-B");
                            if (Aset == 1 && Bset == 2 || Aset == 2 && Bset == 3 || Aset == 3 && Bset == 1) // a b savaşını b kazanırsa
                            {
                                Bhealth = Convert.ToInt16(Bhealth - 25);
                                Ahealth = Convert.ToInt16(Ahealth = 0);

                                double Score = (10 * (Math.Abs(AX - BX) + Math.Abs(AY - BY))) + (100 - Bhealth);
                                Console.WriteLine("A: Defeated       Health:" + Ahealth + "      Score: " + 0);
                                Console.WriteLine("B: Survivor       Health:" + Bhealth + "     Score: " + Score);
                                Console.WriteLine("C: Non-Fighter    Health:" + Chealth + "     Score: " + 0);
                                Console.ReadKey();
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Console.WriteLine("-----------------------------------------");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("ROUND 2: B-C"); // 2.roundu her zaman C kazanır.

                                if (distancebc > 15) // Round 2 de b ve c arasındaki mesafe 15ten büyükse b kazanacak.
                                {
                                    Console.WriteLine("Too Distant, No Attack ");
                                    Console.WriteLine("B has the maximum score :" + "(" + Score + ")");

                                }
                                else
                                {
                                    // 2. round C kazanır

                                    Chealth = Convert.ToInt16(Chealth - 25);
                                    Bhealth = Convert.ToInt16(Bhealth = 0);

                                    double Scorec = (10 * (Math.Abs(CX - BX) + Math.Abs(CY - BY))) + (100 - Chealth);
                                    Console.WriteLine("A: Defeated       Health:" + Ahealth + "      Score: " + 0);
                                    Console.WriteLine("B: Defeated       Health:" + Bhealth + "     Score: " + Score);
                                    Console.WriteLine("C: Survivor       Health:" + Chealth + "     Score: " + Scorec);

                                    if (Scorec > Score)
                                        Console.WriteLine("C has the maximum score " + "(" + Scorec + ")");

                                    else if (Scorec < Score)
                                        Console.WriteLine("B has the maximum score " + "(" + Score + ")");

                                    else
                                        Console.WriteLine("B and C have the maximum score " + "(" + Score + ")");
                                }


                            }
                            else // a b savaşını a kazanırsa
                            {
                                Ahealth = Convert.ToInt16(Ahealth - 25);
                                Bhealth = Convert.ToInt16(Bhealth == 0);

                                double Score = (10 * (Math.Abs(AX - BX) + Math.Abs(AY - BY))) + (100 - Ahealth);
                                Console.WriteLine("A: Survivor       Health:" + Ahealth + "     Score: " + Score);
                                Console.WriteLine("B: Defeated       Health:" + Bhealth + "      Score: " + 0);
                                Console.WriteLine("C: Non-Fighter    Health:" + Chealth + "     Score: " + 0);


                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Console.WriteLine("-----------------------------------------");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                Console.WriteLine("ROUND 2: A-C");

                                if (distanceca > 15)
                                {
                                    Console.WriteLine("Too Distant, No Attack");
                                    Console.WriteLine("A has the maximum score " + "(" + Score + ")");
                                }

                                else  // 2. roundu her zaman C kazanır.
                                {

                                    Chealth = Convert.ToInt16(Chealth - 25);
                                    Ahealth = Convert.ToInt16(Ahealth = 0);

                                    double Scorec = (10 * (Math.Abs(CX - BX) + Math.Abs(CY - BY))) + (100 - Chealth);
                                    Console.WriteLine("A: Defeated       Health:" + Ahealth + "      Score: " + Score);
                                    Console.WriteLine("B: Defeated       Health:" + Bhealth + "     Score: " + 0);
                                    Console.WriteLine("C: Survivor       Health:" + Chealth + "     Score: " + Scorec);

                                    if (Scorec > Score)
                                        Console.WriteLine("C has the maximum score " + "(" + Scorec + ")");

                                    else if (Scorec < Score)
                                        Console.WriteLine("A has the maximum score " + "(" + Score + ")");

                                    else
                                        Console.WriteLine("A and C have the maximum score " + "(" + Score + ")");


                                }

                            }

                        }
                    }

                    else if (min == distancebc) // bc savaşıyor
                    {
                        if (distancebc > 15)
                        {
                            Console.WriteLine("ROUND 1 : B-C");
                            Console.WriteLine("Too Distant, No Attack");
                        }
                        else
                        {
                            Console.WriteLine("ROUND 1 : B-C");
                            if (Cset == 1 && Bset == 2 || Cset == 2 && Bset == 3 || Cset == 3 && Bset == 1) //  B ve C savaşını B kazanırsa
                            {
                                Bhealth = Convert.ToInt16(Bhealth - 25);
                                Chealth = Convert.ToInt16(Chealth = 0);
                                double Score = (10 * (Math.Abs(CX - BX) + Math.Abs(CY - BY))) + (100 - Bhealth);

                                Console.WriteLine("A: Non-Fighter    Health:" + Ahealth + "     Score: " + 0);
                                Console.WriteLine("B: Survivor       Health:" + Bhealth + "     Score: " + Score);
                                Console.WriteLine("C: Defeated       Health:" + Chealth + "      Score: " + 0);


                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Console.WriteLine("-----------------------------------------");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("ROUND 2 : A-B");

                                if (distanceab > 15) // round 2 de mesafe kontrolü
                                {
                                    Console.WriteLine("Too Distant, No Attack");
                                    Console.WriteLine("B has the maximum score " + "(" + Score + ")");
                                }

                                else
                                {

                                    // 2. roundu her zaman A kazanır.

                                    Ahealth = Convert.ToInt16(Ahealth - 25);
                                    Bhealth = Convert.ToInt16(Bhealth = 0);

                                    double ScoreA = (10 * (Math.Abs(BX - AX) + Math.Abs(AY - BY))) + (100 - Ahealth);
                                    Console.WriteLine("A: Survivor       Health:" + Ahealth + "      Score: " + ScoreA);
                                    Console.WriteLine("B: Defeated       Health:" + Bhealth + "     Score: " + Score);
                                    Console.WriteLine("C: Defeated       Health:" + Chealth + "     Score: " + 0);

                                    if (ScoreA > Score)
                                        Console.WriteLine("A has the maximum score " + "(" + ScoreA + ")");

                                    else if (ScoreA < Score)
                                        Console.WriteLine("B has the maximum score " + "(" + Score + ")");

                                    else // skorlarda eşitlik varsa
                                        Console.WriteLine("A and B have the maximum score " + "(" + Score + ")");

                                }


                            }
                            else // B ve C Savaşını C kazanırsa
                            {
                                Chealth = Convert.ToInt16(Chealth - 25);
                                Bhealth = Convert.ToInt16(Bhealth == 0);
                                double Score = (10 * (Math.Abs(CX - BX) + Math.Abs(CY - BY))) + (100 - Chealth);
                                Console.WriteLine("A: Non-Fighter    Health:" + Ahealth + "     Score: " + Convert.ToInt16(Score == 0));
                                Console.WriteLine("B: Defeated       Health:" + Bhealth + "      Score: " + Convert.ToInt16(Score == 0));
                                Console.WriteLine("C: Survivor       Health:" + Chealth + "     Score: " + Score);

                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Console.WriteLine("-----------------------------------------");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                Console.ReadKey();

                                Console.WriteLine("ROUND 2 : A-C ");

                                if (distanceca > 15)
                                {
                                    Console.WriteLine("Too Distant, No Attack ");
                                    Console.WriteLine("C has the maximum score " + "(" + Score + ")");
                                }
                                else
                                {
                                    // 2. roundu her zaman A kazanır.

                                    Ahealth = Convert.ToInt16(Ahealth - 25);
                                    Chealth = Convert.ToInt16(Chealth = 0);

                                    double ScoreA = (10 * (Math.Abs(CX - AX) + Math.Abs(CY - AY))) + (100 - Ahealth);
                                    Console.WriteLine("A: Survivor       Health:" + Ahealth + "      Score: " + ScoreA);
                                    Console.WriteLine("B: Defeated       Health:" + Bhealth + "     Score: " + 0);
                                    Console.WriteLine("C: Defeated       Health:" + Chealth + "     Score: " + Score);

                                    if (ScoreA > Score)
                                        Console.WriteLine("A has the maximum score " + "(" + ScoreA + ")");

                                    else if (ScoreA < Score)
                                        Console.WriteLine("C has the maximum score " + "(" + Score + ")");

                                    else
                                        Console.WriteLine("A and C have the maximum score " + "(" + Score + ")");

                                }
                            }

                        }
                    }
                    else // a ve c savaşıyor
                    {
                        if (distanceca > 15)
                        {
                            Console.WriteLine("ROUND 1 : A-C");
                            Console.WriteLine("Too Distant, No Attack");
                        }
                        else
                        {
                            Console.WriteLine("ROUND 1 : A-C"); // A ve C savaşını A kazsanırsa
                            if (Cset == 1 && Aset == 2 || Cset == 2 && Aset == 3 || Cset == 3 && Aset == 1)
                            {
                                Ahealth = Convert.ToInt16(Ahealth - 25);
                                Chealth = Convert.ToInt16(Chealth = 0);
                                double Score = (10 * (Math.Abs(AX - CX) + Math.Abs(AY - CY))) + (100 - Ahealth);
                                Console.WriteLine("A: Survivor       Health:" + Ahealth + "     Score: " + Score);
                                Console.WriteLine("B: Non-Fighter    Health:" + Bhealth + "     Score: " + 0);
                                Console.WriteLine("C: Defeated       Health:" + Chealth + "      Score: " + 0);

                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Console.WriteLine("-----------------------------------------");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                Console.WriteLine("ROUND 2: A-B ");

                                double ScoreB = (10 * (Math.Abs(BX - AX) + Math.Abs(AY - BY))) + (100 - Bhealth);


                                if (distanceab > 15)
                                {

                                    Console.WriteLine("Too Distant, No Attack");
                                    Console.WriteLine("A has the maximum score " + "(" + Score + ")");

                                }

                                else // 2. roundu her zaman B kazanır.
                                {
                                    Bhealth = Convert.ToInt16(Bhealth - 25);
                                    Ahealth = Convert.ToInt16(Ahealth = 0);

                                    Console.WriteLine("A: Defeated       Health:" + Ahealth + "      Score: " + Score);
                                    Console.WriteLine("B: Survivor       Health:" + Bhealth + "     Score: " + ScoreB);
                                    Console.WriteLine("C: Defeated       Health:" + Chealth + "     Score: " + 0);

                                    if (ScoreB > Score)
                                        Console.WriteLine("B has the maximum score " + "(" + ScoreB + ")");

                                    else if (ScoreB < Score)
                                        Console.WriteLine("A has the maximum score " + "(" + Score + ")");

                                    else
                                        Console.WriteLine("A and B have the maximum score " + "(" + Score + ")");

                                }



                            }
                            else // A ve C savaşını C kazanırsa
                            {
                                Chealth = Convert.ToInt16(Chealth - 25);
                                Ahealth = Convert.ToInt16(Ahealth == 0);
                                double Score = (10 * (Math.Abs(AX - CX) + Math.Abs(AY - CY))) + (100 - Chealth);
                                Console.WriteLine("A: Defeated       Health:" + Ahealth + "     Score: " + 0);
                                Console.WriteLine("B: Non-Fighter    Health:" + Bhealth + "     Score: " + 0);
                                Console.WriteLine("C: Survivor       Health:" + Chealth + "     Score: " + Score);

                                Console.ReadKey();

                                Console.ForegroundColor = ConsoleColor.Magenta;

                                Console.WriteLine("-----------------------------------------");

                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Cyan;

                                Console.WriteLine("ROUND 2 : B-C ");

                                if (distancebc > 15)
                                {
                                    Console.WriteLine("Too Distant, No Attack ");
                                    Console.WriteLine("C has the maximum score " + "(" + Score + ")");

                                }
                                else // 2. roundu her zaman B kazanır.

                                {
                                    Bhealth = Convert.ToInt16(Bhealth - 25);
                                    Chealth = Convert.ToInt16(Chealth = 0);

                                    double ScoreB = (10 * (Math.Abs(BX - CX) + Math.Abs(AY - CY))) + (100 - Bhealth);
                                    Console.WriteLine("A: Defeated       Health:" + Ahealth + "      Score: " + 0);
                                    Console.WriteLine("B: Survivor       Health:" + Bhealth + "     Score: " + ScoreB);
                                    Console.WriteLine("C: Defeated       Health:" + Chealth + "     Score: " + Score);

                                    if (ScoreB > Score)
                                        Console.WriteLine("B has the maximum score " + "(" + ScoreB + ")");

                                    else if (ScoreB < Score)
                                        Console.WriteLine("C has the maximum score " + "(" + Score + ")");

                                    else
                                        Console.WriteLine("B and C have the maximum score " + "(" + Score + ")");



                                }
                            }

                        }
                    }
                    Console.ReadKey();
                }
            }


        }
    }
}


