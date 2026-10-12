using _4_seminars.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_seminars
{
    internal class LoadData
    {

        public static void loadCSVData() {

            List<string[]> locations = new List<string[]>();
            List<string[]> carMake = new List<string[]>();
            List<string[]> fuelType = new List<string[]>();
            List<string[]> car = new List<string[]>();

            string path = "Electric_Vehicle_Population_Data.csv";
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines.Skip(1)) { //Skip izlai'z pirmo rindu un tupina saja gadijuma kolonu nosaukumus
                string[] splitLine = line.Split(',');

                string[] loactionArr = splitLine.Skip(1).Take(4).ToArray(); //skipo pirmo kolonnu jo taja nav ieklauts location un nemt tikai 4kolonas pec tam
                string[] fuelTypeArr = splitLine.Skip(8).Take(2).ToArray();
                string[] carMakeArr = splitLine.Skip(5).Take(3).ToArray();
                string[] carArr = { //splitLine.Take(1).Skip(9).Take(7).ToArray(); nestrada
                        splitLine[0],
                        splitLine[10],
                        splitLine[11],
                        splitLine[12],
                        splitLine[13],
                        splitLine[14],
                        splitLine[15],
                        splitLine[16]
                };

                locations.Add(loactionArr);
                carMake.Add(loactionArr);
                fuelType.Add(fuelTypeArr);
                car.Add(loactionArr);

            }

            locations = removeDuplicate(locations);
            carMake = removeDuplicate(carMake);
            fuelType = removeDuplicate(fuelType);
            car = removeDuplicate(car);

            Form1 form = new Form1();
            DataGridView dgv = new DataGridView();
            dgv.DataSource = fuelType;
            form.Controls.Add(dgv);
            //form.ShowDialog();
            

            Debug.WriteLine(fuelType.Count.ToString());


        }

        // LINQ - Language integrated query
        //nonemt duplikatus
        public static List<string[]> removeDuplicate(List<string[]> arr) {
            return (from row in arr 
                    group row by string.Join(".", row) into groupedRows
                    select groupedRows.First()).ToList();
        }
        //var ari sadi
        public List<string[]> removeDuplicate2(List<string[]> arr)
        {
            return arr.GroupBy(row => string.Join(",", row)).Select(groupedRows => groupedRows.First()).ToList();
        }

        //public static (List<string[]>, List<string[]>, List<string[]>, List<string[]>) duplicateDeleter(List<string[]> location, List<string[]> carMake, List<string[]> fuelType, List<string[]> car) {
        //    var locationClean = location.Distinct().ToList();
        //    var carMakeClean = carMake.Distinct().ToList();
        //    var fuelTypeClean = fuelType.Distinct().ToList();
        //    var carClean = carMake.Distinct().ToList();
        //    return (locationClean, carMakeClean, fuelTypeClean, carClean);
        //} Nestrada



    }
}
