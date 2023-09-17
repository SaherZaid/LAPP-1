
            Console.Write("Input: ");
            string input = Console.ReadLine();
            string bold = "";
            int count = 0;
            long sum = 0;


            for (int i = 0; i < input.Length; i++)
            {


                bold = "";

                if (Char.IsDigit(input[i]))
                {
                    bold += input[i];
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (Char.IsDigit(input[j]))
                        {
                            bold += input[j];
                            if (input[i] == input[j])
                            {
                                count++;
                                sum += Convert.ToInt64(bold);
                                Console.ResetColor();
                                Console.Write(input.Substring(0, i));
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(bold);
                                Console.ResetColor();
                                Console.WriteLine(input.Substring(j + 1, (input.Length - (j + 1))));

                                bold = "";
                                j = input.Length;
                            }

                        }
                        else
                        {
                            bold = "";
                            j = input.Length;


                        }


                    }

                }
                else
                {
                    //bold = "";
                    continue;

                }

            }
            Console.WriteLine("Count : " + count);
            Console.WriteLine("Sum : " + sum);
  