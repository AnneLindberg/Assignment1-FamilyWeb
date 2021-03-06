﻿using System;
using System.Threading.Tasks;
using FamilyWeb1.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using FileData;
using Models;

namespace AdultService
{
    public class AdultService : IAdultService
    {
        private string adultFile = "adults.json";
        private IList<Adult> _adults;
        private FileContext _fileContext = new FileContext();
        private HttpClient client;

        public AdultService()
        {
            client = new HttpClient();
            if (!File.Exists(adultFile))
            {
                Seed();
                WriteAdultsToFile();
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                _adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        private void WriteAdultsToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(_adults);
            File.WriteAllText(adultFile, productsAsJson);
        }
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> tmp = new List<Adult>(_adults);
            return tmp;
        }

        public async Task<IList<Adult>> GetAllAdults(string query)
        {
            string httpsJsonplaceholderTypicodeComTodos = "https://localhost:5005/Adults" + query;
            string message = await client.GetStringAsync(httpsJsonplaceholderTypicodeComTodos);
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            int max = _adults.Max(adult => adult.id);
            adult.id = (++max);
            _adults.Add(adult);
            WriteAdultsToFile();
            return adult;
        }

        public Task RemoveAdultAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public int addId()
        {
            int j = 0;
            for (int i = 0; i < _fileContext.Adults.Count; i++)
            {
                if (_fileContext.Adults[i].id != i)
                {
                    return i;
                }
            }

            return _fileContext.Adults.Count;
        }
        private void Seed()
        {
            Adult[] ts =
            {
                new Adult()
                {
                    id = 1,
                    firstName = "Anne",
                    lastName = "Lindberg",
                    hairColor = "leverpostej",
                    eyeColor = "Blue",
                    age = 26,
                    weight = 62,
                    height = 164,
                    JobTitle = "Student"
                }
            };
            _adults = ts.ToList();
        }
    }
}