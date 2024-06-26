﻿using WebApplication1.Model;

namespace WebApplication1.Services;

public interface IAnimalsService
{
    public IEnumerable<Animal> GetAnimals(string orderBy);
    public int CreateAnimal(Animal animal);
    public int UpdateAnimal(int id,Animal animal);
    public int DeleteAnimal(int id);
}