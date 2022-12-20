using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2_Ass2
{
    internal class Map
    {
        public List<Road> roads = new List<Road>();
        public List<City> cities = new List<City>();
        private List<City> visited = new List<City>();
        private List<City> notVisited = new List<City>();

        public void fillMap()
        {
        
            City Varna = new City("Varna");
            cities.Add(Varna);
            City Dobrich = new City("Dobrich");
            cities.Add(Dobrich);
            City Burgas = new City("Burgas");
            cities.Add(Burgas);
            City Silistra = new City("Silistra");
            cities.Add(Silistra);
            City Razgrad = new City("Razgrad");
            cities.Add(Razgrad);
            City Shumen = new City("Shumen");
            cities.Add(Shumen);
            City Yambol = new City("Yambol");
            cities.Add(Yambol);
            City Turgovishte = new City("Turgovishte");
            cities.Add(Turgovishte);
            City VelikoTurnovo = new City("Veliko Turnovo");
            cities.Add(VelikoTurnovo);
            City Plovdiv = new City("Plovdiv");
            cities.Add(Plovdiv);
            City Sofia = new City("Sofia");
            cities.Add(Sofia);
            notVisited = cities.ToList();

            Road VarnaDobrich = new Road(Varna, Dobrich, 60, 52);
            Road VarnaBurgas = new Road(Varna, Burgas, 60, 120);
            Road DobrichSilistra = new Road(Dobrich, Silistra, 60, 90);
            Road VarnaRazgrad = new Road(Varna, Razgrad, 60, 128);
            Road SilistraRazgrad = new Road(Silistra, Razgrad, 60, 115);
            Road RazgradTurgovishte = new Road(Razgrad, Turgovishte, 60, 38);
            Road TurgovishteShumen = new Road(Turgovishte, Shumen, 90, 41);
            Road VarnaShumen = new Road(Varna, Shumen, 60, 89);
            Road TurgovishteVelikoTurnovo = new Road(Turgovishte, VelikoTurnovo, 90, 100);
            Road BurgasYambol = new Road(Burgas, Yambol, 60, 92);
            Road ShumenYambol = new Road(Shumen, Yambol, 60, 129);
            Road YambolVelikoTurnovo = new Road(Yambol, VelikoTurnovo,60, 130);
            Road VelikoTurnovoPlovdiv = new Road(VelikoTurnovo, Plovdiv, 90, 204);
            Road YambolPlovdiv = new Road(Yambol, Plovdiv,60, 169);
            Road VelikoTurnovoSofia = new Road(VelikoTurnovo, Sofia, 90, 219);
            Road PlovdivSofia = new Road(Plovdiv, Sofia, 60, 144);
            Road BurgasShumen = new Road(Burgas, Shumen, 60, 128);
            roads.Add(VarnaDobrich);
            roads.Add(VarnaBurgas);
            roads.Add(VarnaShumen);
            roads.Add(DobrichSilistra);
            roads.Add(BurgasShumen);
            roads.Add(VarnaRazgrad);
            roads.Add(SilistraRazgrad);
            roads.Add(RazgradTurgovishte);
            roads.Add(TurgovishteShumen);
            roads.Add(TurgovishteVelikoTurnovo);
            roads.Add(BurgasYambol);
            roads.Add(ShumenYambol);
            roads.Add(YambolVelikoTurnovo);
            roads.Add(VelikoTurnovoPlovdiv);
            roads.Add(YambolPlovdiv);
            roads.Add(VelikoTurnovoSofia);
            roads.Add(PlovdivSofia);


        }
        private List<City> GetNeighbours(string city)
        {
            List<City> result = new List<City>();
            foreach (var item in roads)
            {
                if (item.city1.name.Equals(city)) result.Add(item.city2);
                if (item.city2.name.Equals(city)) result.Add(item.city1);
            }
            return result;
        }
        public void DoDijkstraMagic(string startingCity)
        {
            City current = null;
            current = findCity(startingCity, current);
            current.timeToReachThisCity = 0;
            CalculateAllPaths(startingCity);
        }
        private void CalculateAllPaths(string startingCity)
        {
            City current = null;
            current = findCity(startingCity, current);
            if (visited.Contains(current)) return;
            visited.Add(current);
            notVisited.Remove(current);

            List<City> neighbours = new List<City>();
            neighbours = GetNeighbours(current.name);
            foreach (var neighbour in neighbours)
            {
                foreach (var road in roads)
                {
                    if ((road.city1.name.Equals(neighbour.name) && road.city2.name.Equals(current.name)) ||
                        (road.city1.name.Equals(current.name) && road.city2.name.Equals(neighbour.name)))
                    {
                        if (neighbour.timeToReachThisCity > current.timeToReachThisCity + road.distance / road.maxSpeed)
                        {
                            neighbour.timeToReachThisCity = current.timeToReachThisCity + road.distance / road.maxSpeed;
                            neighbour.pointerToPreviousCity = current;
                        }
                    }
                }

            }
            
            foreach (var neighbour in neighbours)
            {
                CalculateAllPaths(neighbour.name);
            }
        }
        public void printTheWay(string destinationName)
        {
            City destination = null;
            destination = findCity(destinationName, destination);
            getRoadsInternal(destination);
        }

        private void getRoadsInternal(City city)
        {
            if (city == null) return;
            if (city.pointerToPreviousCity == null) return;
            City start = city;
            City other = city.pointerToPreviousCity;
            Console.WriteLine(start.name + " " + start.pointerToPreviousCity.name);
            getRoadsInternal(other);
        }
        public List<City> getCitiesPath(string destination)
        {
            List<City> result = new List<City>();
            City current = null;
            current = findCity(destination, current);

            while (current != null)
            {
                result.Add(current);
                current = current.pointerToPreviousCity;
            }
            return result;
        }
        public City findCity(string destinationName, City destination)
        {
            foreach (var city in cities)
            {
                if (city.name.Equals(destinationName)) destination = city;
            }

            return destination;
        }
    }
}