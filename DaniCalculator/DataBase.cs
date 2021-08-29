using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DaniCalculator
{
    class Database
    {
        public static string[] databaseRead(string searchtearm, string filepath, int postionOfTerm)
        {
            postionOfTerm--;
            string[] recordNotFound = { "Data not Found" };
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath);
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(",");
                        if(databaseValidate(searchtearm,fields,postionOfTerm))
                        {
                            return fields;
                        }

                    }
                    return recordNotFound;
                }

            }catch(Exception ex)
            {
                throw new Exception("something happened, idk");
            }
        }

        public static bool databaseValidate(string credential, string[] record, int positionOfTerm)
        {
            if(record[positionOfTerm].Equals(credential))
            {
                return true;
            }
            return false;

        }
        
    }



}
