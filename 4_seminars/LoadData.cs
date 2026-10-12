using _4_seminars.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _4_seminars
{
    internal class LoadData
    {
        
        public static void loadCSVData() {

            AppDbContext db = new AppDbContext();
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
                //string[] carArr = { //splitLine.Take(1).Skip(9).Take(7).ToArray(); nestrada
                //        splitLine[0],
                //        splitLine[10],
                //        splitLine[11],
                //        splitLine[12],
                //        splitLine[13],
                //        splitLine[14],
                //        splitLine[15],
                //        splitLine[16]
                //};

                locations.Add(loactionArr);
                carMake.Add(loactionArr);
                fuelType.Add(fuelTypeArr);
                car.Add(splitLine);

            }

            locations = removeDuplicate(locations);
            carMake = removeDuplicate(carMake);
            fuelType = removeDuplicate(fuelType);
            car = removeDuplicate(car);

            //Pievieno Klases objektus
            foreach (var item in fuelType) { 
                FuelType uniqueFuelType = new FuelType(item[0], item[1]);

                db.FuelTypes.Add(uniqueFuelType);
            }
            foreach (var item in locations) { 
                Location uniquelocations = new Location(item[0], item[1], item[2], int.Parse(item[3]));

                db.Locations.Add(uniquelocations);
            }
            foreach (var item in carMake) {
                CarMake uniqueCarMake = new CarMake(item[0], item[1], item[2]);

                db.CarMakes.Add(uniqueCarMake);
            }
            db.SaveChanges();
            foreach (var item in car) {
                try
                {
                    //Car uniqueCar = new Car();
                    int fuelTypeID = db.FuelTypes
                        .Where(ft =>
                            ft.ElectricVehicleType == item[8] &&
                            ft.CAFV == item[9]
                            )
                        .Select(ft => ft.Id)
                        .FirstOrDefault();

                    int carMakeID = db.CarMakes
                        .Where(ft =>
                            ft.Modelyear == item[5] &&
                            ft.Make == item[6] &&
                            ft.Model == item[7]
                            )
                        .Select(ft => ft.Id)
                        .FirstOrDefault();

                    int locationID = db.Locations
                        .Where(ft =>
                            ft.County == item[1] &&
                            ft.City == item[2] &&
                            ft.State == item[3] &&
                            ft.PostalCode == int.Parse(item[4])
                            )
                        .Select(ft => ft.Id)
                        .FirstOrDefault();
                    Car uniqueCar = new Car(item[0], int.Parse(item[10]), int.Parse(item[11]), int.Parse(item[12]), int.Parse(item[13]), item[14], item[15], long.Parse(item[16]), locationID, carMakeID, fuelTypeID);
                    db.Cars.Add(uniqueCar);
                }
                catch (Exception) {
                    continue;
                }

                //try
                //{
                //    Car uniqueCar = new Car(item[0], int.Parse(item[1]), int.Parse(item[2]), int.Parse(item[3]), int.Parse(item[4]), item[5], item[6], long.Parse(item[7]));
                    
                //    db.Cars.Add(uniqueCar);
                //}
                //catch (System.FormatException) {
                //    continue;
                //}
            }

            db.SaveChanges();



            //Form1 form = new Form1();
            //DataGridView dgv = new DataGridView();
            //dgv.DataSource = fuelType;
            //form.Controls.Add(dgv);
            ////form.ShowDialog();
            

            //Debug.WriteLine(fuelType.Count.ToString());


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
