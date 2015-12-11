using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Packing
{
    class Program
    {
        static void Main(string[] args)
        {
            //the items in the package
            int itemID = 0;
            double itemWeight = 0;
            double itemCost = 0;
            string[] itemDetails; List<itemsForPacking> potentialItemsToPack = new List<itemsForPacking>();

            using (StreamReader reader = File.OpenText("test.txt"))
            {
                while (!reader.EndOfStream)
                {
                    //read the text line by line
                    string line = reader.ReadLine();

                    //split the text at the colon to create two substrings
                    string[] splitLine = line.Split(new char[] { ':' });

                    //first substring is the weight limit for the package
                    int weightLimit = Convert.ToInt32(splitLine[0].TrimEnd());

                    //trim out the extra white space from the second substring
                    splitLine[1] = splitLine[1].TrimStart();

                    //split the second substring into groups of items
                    string[] items = splitLine[1].Split(new char[] { ' ' });
                    //loop through all the items and seperate out the peices into individual variables
                    for (int i = 0; i < items.Length; i++)
                    {

                        //first remove the parens
                        items[i] = items[i].Trim(new char[] { '(', ')' });
                        //split the items at the comma
                        itemDetails = items[i].Split(new char[] { ',' });
                        //get the itemID 
                        itemID = Convert.ToInt32(itemDetails[0]);
                        //get the item weight
                        itemWeight = Convert.ToDouble(itemDetails[1]);
                        //get the item cost
                        itemCost = Convert.ToDouble(itemDetails[2].Trim(new char[] { '$' }));
                        //total up the cost of the items


                        if (itemWeight < weightLimit)
                        {
                            //repack the items into an object
                            itemsForPacking AnItem = new itemsForPacking()
                            {
                                _itemID = itemID,
                                _itemWeight = itemWeight,
                                _itemCost = itemCost

                            };
                            //a list of items that are less than the weight limit.
                            potentialItemsToPack.Add(AnItem);
                        }

                    }
                    //send each items to PackageBox class
                    PackageBox(potentialItemsToPack, weightLimit);

                }

                Console.Read();
            }
        }

        static void PackageBox(List<itemsForPacking> potentialItemsToPack, int weightLimit)
        {

            double remainingWeight = weightLimit;
            List<string> packedItems = new List<string>();
            List<itemsForPacking> SortedList = potentialItemsToPack.OrderByDescending(o => o._itemCost).ThenBy(o => o._itemWeight).ToList();
            double tempCost = 0;

            for (int i = 0; i < SortedList.Count - 1; i++)
            {
                if (remainingWeight - SortedList[i]._itemWeight > 0 && SortedList[i]._itemCost >= tempCost)
                {
                    packedItems.Add(SortedList[i]._itemID.ToString());
                    remainingWeight = remainingWeight - SortedList[i]._itemWeight;
                }
            }

            if (packedItems.Count < 1)
            {
                packedItems.Add("-");
            }
            potentialItemsToPack.Clear();
            DisplayItems(packedItems);
        }

        static void DisplayItems(List<string> packedItems)
        {
            int count = 1;
            foreach (var item in packedItems)
            {

                if (packedItems.Count > 1)
                {
                    if (count == packedItems.Count)
                    {
                        Console.WriteLine(item);
                    }
                    else
                    {
                        Console.Write(item + ",");
                        count++;
                    }
                   

                }
                else
                {
                    Console.WriteLine(item);
                }

            }
        }

        public class itemsForPacking
        {
            public int _itemID { get; set; }
            public double _itemWeight { get; set; }
            public double _itemCost { get; set; }
        }
    }
}