using AutoMapper;
using GameObjectMapper.Dtos;
using GameObjectMapper.Enum;
using GameObjectMapper.Mappers.AutoMapperExemple;
using GameObjectMapper.Mappers.ExtensionMethodExemple;
using GameObjectMapper.Mappers.MapsterExample;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

//
// 1. Mapster: Fast, lightweight and easy-to-use object mapper.
//
MapsterConfig.Configure();
var characterMapster = new GameObjectMapper.Models.Character
{
    Id = 1,
    Name = "Luna",
    Class = CharacterClass.Mage,
    Level = 20,
    Health = 100.0,
    IsNPC = false,
    CreatedAt = DateTime.UtcNow
};
var dtoMapster = characterMapster.Adapt<CharacterDTO>();
Console.WriteLine($"\nMapster:\n{dtoMapster}\n");

//
// 2. AutoMapper: Popular library that supports advanced mapping configurations.
//
var serviceCollection = new ServiceCollection();
serviceCollection.AddAutoMapper(typeof(AutoMapperProfile));
var serviceProvider = serviceCollection.BuildServiceProvider();
var mapper = serviceProvider.GetRequiredService<IMapper>();

var characterAutoMapper = new GameObjectMapper.Models.Character
{
    Id = 2,
    Name = "Thorin",
    Class = CharacterClass.Warrior,
    Level = 30,
    Health = 250.0,
    IsNPC = false,
    CreatedAt = DateTime.UtcNow
};
var dtoAutoMapper = mapper.Map<CharacterDTO>(characterAutoMapper);
Console.WriteLine($"AutoMapper:\n{dtoAutoMapper}\n");

//
// 3. Explicit Operator: Manual mapping that requires explicit casting.
//    Good for controlled and readable transformations.
//
var characterExplicit = new GameObjectMapper.Mappers.ExplicitOperatorExemple.Character
{
    Id = 3,
    Name = "Archer",
    Class = CharacterClass.Archer,
    Level = 15,
    Health = 120.0,
    IsNPC = true,
    CreatedAt = DateTime.UtcNow
};
var dtoExplicit = (CharacterDTO)characterExplicit;
Console.WriteLine($"Explicit Operator:\n{dtoExplicit}\n");

//
// 4. Implicit Operator: Manual mapping using implicit conversion.
//    Offers a clean syntax but less explicit than the explicit cast.
//
var characterImplicit = new GameObjectMapper.Mappers.ImplicitOperatorExemple.Character
{
    Id = 4,
    Name = "Stealth",
    Class = CharacterClass.Thief,
    Level = 18,
    Health = 150.0,
    IsNPC = false,
    CreatedAt = DateTime.UtcNow
};
CharacterDTO dtoImplicit = characterImplicit;
Console.WriteLine($"Implicit Operator:\n{dtoImplicit}\n");

//
// 5. Extension Method: Reusable and readable conversion logic through a custom method.
//    Highly maintainable and good for testability.
//
var characterExtension = new GameObjectMapper.Models.Character
{
    Id = 5,
    Name = "Guardian",
    Class = CharacterClass.Warrior,
    Level = 25,
    Health = 300.0,
    IsNPC = false,
    CreatedAt = DateTime.UtcNow
};
var dtoExtension = characterExtension.ToDTO();
Console.WriteLine($"Extension Method:\n{dtoExtension}\n");
